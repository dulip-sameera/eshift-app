using eshift.Database;
using eshift.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using eshift.Dto;
using System;
using eshift.Enums;

namespace eshift.Dao.Impl
{
    internal class JobDaoImpl : IJobDao
    {
        public List<(JobModel, string, string, string)> GetAllJobsWithCustomerAndStatus()
        {
            var list = new List<(JobModel, string, string, string)>();
            using var conn = DatabaseConnection.Instance.Connection;
            string query = @"SELECT j.id, j.job_id, j.pickup_location, j.delivery_location, j.scheduled_date, j.estimated_cost, j.actual_cost, j.status, j.customer, j.description, j.created_at,
                                    c.cus_id, c.first_name, s.name as status_name
                             FROM job j
                             JOIN customer c ON j.customer = c.id
                             JOIN job_status s ON j.status = s.id";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var jobModel = new JobModel(
                    reader.GetInt32("id"),
                    reader.GetString("job_id"),
                    reader.GetString("pickup_location"),
                    reader.GetString("delivery_location"),
                    reader.GetDateTime("scheduled_date"),
                    reader.IsDBNull(reader.GetOrdinal("estimated_cost")) ? null : reader.GetDouble("estimated_cost"),
                    reader.IsDBNull(reader.GetOrdinal("actual_cost")) ? null : reader.GetDouble("actual_cost"),
                    reader.GetInt32("status"),
                    reader.GetInt32("customer"),
                    reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description"),
                    reader.IsDBNull(reader.GetOrdinal("created_at")) ? DateTime.Now : reader.GetDateTime("created_at")
                );
                string cusId = reader.GetString("cus_id");
                string firstName = reader.GetString("first_name");
                string statusName = reader.GetString("status_name");
                list.Add((jobModel, cusId, firstName, statusName));
            }
            return list;
        }

        public (JobModel, string, string, string)? GetJobWithCustomerAndStatusByJobId(string jobId)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = @"SELECT j.id, j.job_id, j.pickup_location, j.delivery_location, j.scheduled_date, j.estimated_cost, j.actual_cost, j.status, j.customer, j.description, j.created_at,
                                    c.cus_id, c.first_name, s.name as status_name
                             FROM job j
                             JOIN customer c ON j.customer = c.id
                             JOIN job_status s ON j.status = s.id
                             WHERE j.job_id = @jobId LIMIT 1";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@jobId", jobId);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var jobModel = new JobModel(
                    reader.GetInt32("id"),
                    reader.GetString("job_id"),
                    reader.GetString("pickup_location"),
                    reader.GetString("delivery_location"),
                    reader.GetDateTime("scheduled_date"),
                    reader.IsDBNull(reader.GetOrdinal("estimated_cost")) ? null : reader.GetDouble("estimated_cost"),
                    reader.IsDBNull(reader.GetOrdinal("actual_cost")) ? null : reader.GetDouble("actual_cost"),
                    reader.GetInt32("status"),
                    reader.GetInt32("customer"),
                    reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description"),
                    reader.IsDBNull(reader.GetOrdinal("created_at")) ? DateTime.Now : reader.GetDateTime("created_at")
                );
                string cusId = reader.GetString("cus_id");
                string firstName = reader.GetString("first_name");
                string statusName = reader.GetString("status_name");
                return (jobModel, cusId, firstName, statusName);
            }
            return null;
        }

        public bool UpdateJobStatusByJobId(string jobId, int statusId)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = "UPDATE job SET status = @statusId WHERE job_id = @jobId";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@statusId", statusId);
            cmd.Parameters.AddWithValue("@jobId", jobId);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool UpdateJob(string jobId, JobModel model)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = @"UPDATE job SET pickup_location = @pickup, delivery_location = @delivery, scheduled_date = @scheduledDate,
                             estimated_cost = @estimatedCost, actual_cost = @actualCost, status = @status, customer = @customer, description = @description
                             WHERE job_id = @jobId";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@pickup", model.PickupLocation);
            cmd.Parameters.AddWithValue("@delivery", model.DeliveryLocation);
            cmd.Parameters.AddWithValue("@scheduledDate", model.ScheduledDate);
            cmd.Parameters.AddWithValue("@estimatedCost", model.EstimatedCost);
            cmd.Parameters.AddWithValue("@actualCost", model.ActualCost);
            cmd.Parameters.AddWithValue("@status", model.StatusId);
            cmd.Parameters.AddWithValue("@customer", model.CustomerId);
            cmd.Parameters.AddWithValue("@description", model.Description);
            cmd.Parameters.AddWithValue("@jobId", jobId);
            return cmd.ExecuteNonQuery() > 0;
        }

        public void CreateJob(string jobId, CreateJobFormDto dto, int statusId)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            using var transaction = conn.BeginTransaction();
            try
            {
                // Insert job
                string jobQuery = @"INSERT INTO job (job_id, pickup_location, delivery_location, scheduled_date, estimated_cost, status, customer, description, created_at) VALUES (@jobId, @pickup, @delivery, @scheduledDate, @estimatedCost, @status, @customer, @description, @createdAt)";
                using var jobCmd = new MySqlCommand(jobQuery, conn, transaction);
                jobCmd.Parameters.AddWithValue("@jobId", jobId);
                jobCmd.Parameters.AddWithValue("@pickup", dto.Pickup);
                jobCmd.Parameters.AddWithValue("@delivery", dto.Delivery);
                jobCmd.Parameters.AddWithValue("@scheduledDate", dto.ScheduledDate);
                jobCmd.Parameters.AddWithValue("@estimatedCost", dto.EstimatedCost);
                jobCmd.Parameters.AddWithValue("@status", statusId);
                jobCmd.Parameters.AddWithValue("@customer", dto.CustomerId);
                jobCmd.Parameters.AddWithValue("@description", dto.Description ?? (object)DBNull.Value);
                jobCmd.Parameters.AddWithValue("@createdAt", DateTime.Now.Date);
                jobCmd.ExecuteNonQuery();
                // Get inserted job DB id
                int jobDbId = 0;
                using (var idCmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn, transaction))
                {
                    jobDbId = Convert.ToInt32(idCmd.ExecuteScalar());
                }
                // Insert loads
                if (dto.Loads != null && dto.Loads.Count > 0)
                {
                    foreach (var load in dto.Loads)
                    {
                        string loadQuery = @"INSERT INTO `load` (load_id, description, volume, weight, job) VALUES (@loadId, @description, @volume, @weight, @job)";
                        using var loadCmd = new MySqlCommand(loadQuery, conn, transaction);
                        loadCmd.Parameters.AddWithValue("@loadId", load.LoadId);
                        loadCmd.Parameters.AddWithValue("@description", load.Description);
                        loadCmd.Parameters.AddWithValue("@volume", load.Volume);
                        loadCmd.Parameters.AddWithValue("@weight", load.Weight);
                        loadCmd.Parameters.AddWithValue("@job", jobDbId);
                        loadCmd.ExecuteNonQuery();
                    }
                }


                // Insert job_transport_unit
                if (dto.TransportUnits != null && dto.TransportUnits.Count > 0)
                {
                    foreach (var tu in dto.TransportUnits)
                    {
                        string jtQuery = @"INSERT INTO job_transport_unit (job, transport_unit) VALUES (@job, @tu)";
                        using var jtCmd = new MySqlCommand(jtQuery, conn, transaction);
                        jtCmd.Parameters.AddWithValue("@job", jobDbId);
                        jtCmd.Parameters.AddWithValue("@tu", tu.Id);
                        jtCmd.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
        }

        public List<JobModel> GetJobsByStatus(string status)
        {
            var list = new List<JobModel>();
            using var conn = DatabaseConnection.Instance.Connection;
            string query = @"SELECT j.id, j.job_id, j.pickup_location, j.delivery_location, j.scheduled_date, j.estimated_cost, j.actual_cost, j.status, j.customer, j.description, j.created_at
                             FROM job j
                             JOIN job_status s ON j.status = s.id
                             WHERE s.name = @status";
            try
            {
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", status);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var jobModel = new JobModel(
                        reader.GetInt32("id"),
                        reader.GetString("job_id"),
                        reader.GetString("pickup_location"),
                        reader.GetString("delivery_location"),
                        reader.GetDateTime("scheduled_date"),
                        reader.IsDBNull(reader.GetOrdinal("estimated_cost")) ? null : reader.GetDouble("estimated_cost"),
                        reader.IsDBNull(reader.GetOrdinal("actual_cost")) ? null : reader.GetDouble("actual_cost"),
                        reader.GetInt32("status"),
                        reader.GetInt32("customer"),
                        reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description"),
                        reader.IsDBNull(reader.GetOrdinal("created_at")) ? DateTime.Now : reader.GetDateTime("created_at")
                    );
                    list.Add(jobModel);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetJobsByStatus: {ex.Message}");
                throw;
            }
            return list;
        }

        public List<JobModel> FilterJobsByJobId(string jobId)
        {
            var list = new List<JobModel>();
            using var conn = DatabaseConnection.Instance.Connection;
            string query = @"SELECT j.id, j.job_id, j.pickup_location, j.delivery_location, j.scheduled_date, j.estimated_cost, j.actual_cost, j.status, j.customer, j.description, j.created_at
                             FROM job j
                             WHERE j.job_id LIKE @jobId";
            try
            {
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@jobId", $"%{jobId}%");
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var jobModel = new JobModel(
                        reader.GetInt32("id"),
                        reader.GetString("job_id"),
                        reader.GetString("pickup_location"),
                        reader.GetString("delivery_location"),
                        reader.GetDateTime("scheduled_date"),
                        reader.IsDBNull(reader.GetOrdinal("estimated_cost")) ? null : reader.GetDouble("estimated_cost"),
                        reader.IsDBNull(reader.GetOrdinal("actual_cost")) ? null : reader.GetDouble("actual_cost"),
                        reader.GetInt32("status"),
                        reader.GetInt32("customer"),
                        reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description"),
                        reader.IsDBNull(reader.GetOrdinal("created_at")) ? DateTime.Now : reader.GetDateTime("created_at")
                    );
                    list.Add(jobModel);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in FilterJobsByJobId: {ex.Message}");
                throw;
            }
            return list;
        }

        public JobWithLoadsDto? GetJobWithLoadsByJobId(string jobId)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            try
            {
                // First get the job with customer CusId
                JobModel? job = null;
                string customerCusId = string.Empty;
                string jobQuery = @"SELECT j.id, j.job_id, j.pickup_location, j.delivery_location, j.scheduled_date, j.estimated_cost, j.actual_cost, j.status, j.customer, j.description, j.created_at, c.cus_id
                                   FROM job j
                                   JOIN customer c ON j.customer = c.id
                                   WHERE j.job_id = @jobId LIMIT 1";
                
                using (var jobCmd = new MySqlCommand(jobQuery, conn))
                {
                    jobCmd.Parameters.AddWithValue("@jobId", jobId);
                    using var jobReader = jobCmd.ExecuteReader();
                    if (jobReader.Read())
                    {
                        job = new JobModel(
                            jobReader.GetInt32("id"),
                            jobReader.GetString("job_id"),
                            jobReader.GetString("pickup_location"),
                            jobReader.GetString("delivery_location"),
                            jobReader.GetDateTime("scheduled_date"),
                            jobReader.IsDBNull(jobReader.GetOrdinal("estimated_cost")) ? null : jobReader.GetDouble("estimated_cost"),
                            jobReader.IsDBNull(jobReader.GetOrdinal("actual_cost")) ? null : jobReader.GetDouble("actual_cost"),
                            jobReader.GetInt32("status"),
                            jobReader.GetInt32("customer"),
                            jobReader.IsDBNull(jobReader.GetOrdinal("description")) ? null : jobReader.GetString("description"),
                            jobReader.IsDBNull(jobReader.GetOrdinal("created_at")) ? DateTime.Now : jobReader.GetDateTime("created_at")
                        );
                        customerCusId = jobReader.GetString("cus_id");
                    }
                }

                if (job == null)
                {
                    return null;
                }

                // Get loads for the job
                var loads = new List<LoadDto>();
                string loadQuery = @"SELECT load_id, description, volume, weight FROM `load` WHERE job = @jobDbId";
                
                using (var loadCmd = new MySqlCommand(loadQuery, conn))
                {
                    loadCmd.Parameters.AddWithValue("@jobDbId", job.Id);
                    using var loadReader = loadCmd.ExecuteReader();
                    while (loadReader.Read())
                    {
                        var load = new LoadDto
                        {
                            LoadId = loadReader.GetString("load_id"),
                            Description = loadReader.GetString("description"),
                            Volume = loadReader.GetDouble("volume"),
                            Weight = loadReader.GetDouble("weight")
                        };
                        loads.Add(load);
                    }
                }

                return new JobWithLoadsDto
                {
                    JobId = job.JobId,
                    Customer = customerCusId,
                    PickupLocation = job.PickupLocation,
                    DeliveryLocation = job.DeliveryLocation,
                    ScheduledDate = job.ScheduledDate,
                    EstimatedCost = job.EstimatedCost,
                    ActualCost = job.ActualCost,
                    Description = job.Description,
                    Loads = loads
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetJobWithLoadsByJobId: {ex.Message}");
                throw new Exception($"Failed to retrieve job with loads for JobId: {jobId}", ex);
            }
        }

        public JobWithLoadsAndTransportUnitDto? GetJobWithLoadsAndTransportUnitsByJobId(string jobId)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            try
            {
                // First get the job with customer details
                JobModel? job = null;
                string customerCusId = string.Empty;
                string customerName = string.Empty;
                string jobQuery = @"SELECT j.id, j.job_id, j.pickup_location, j.delivery_location, j.scheduled_date, j.estimated_cost, j.actual_cost, j.status, j.customer, j.description, j.created_at, c.cus_id, CONCAT(c.first_name, ' ', c.last_name) as customer_name
                                   FROM job j
                                   JOIN customer c ON j.customer = c.id
                                   WHERE j.job_id = @jobId LIMIT 1";
                
                using (var jobCmd = new MySqlCommand(jobQuery, conn))
                {
                    jobCmd.Parameters.AddWithValue("@jobId", jobId);
                    using var jobReader = jobCmd.ExecuteReader();
                    if (jobReader.Read())
                    {
                        job = new JobModel(
                            jobReader.GetInt32("id"),
                            jobReader.GetString("job_id"),
                            jobReader.GetString("pickup_location"),
                            jobReader.GetString("delivery_location"),
                            jobReader.GetDateTime("scheduled_date"),
                            jobReader.IsDBNull(jobReader.GetOrdinal("estimated_cost")) ? null : jobReader.GetDouble("estimated_cost"),
                            jobReader.IsDBNull(jobReader.GetOrdinal("actual_cost")) ? null : jobReader.GetDouble("actual_cost"),
                            jobReader.GetInt32("status"),
                            jobReader.GetInt32("customer"),
                            jobReader.IsDBNull(jobReader.GetOrdinal("description")) ? null : jobReader.GetString("description"),
                            jobReader.IsDBNull(jobReader.GetOrdinal("created_at")) ? DateTime.Now : jobReader.GetDateTime("created_at")
                        );
                        customerCusId = jobReader.GetString("cus_id");
                        customerName = jobReader.GetString("customer_name");
                    }
                }

                if (job == null)
                {
                    return null;
                }

                // Get loads for the job
                var loads = new List<LoadDto>();
                string loadQuery = @"SELECT load_id, description, volume, weight FROM `load` WHERE job = @jobDbId";
                
                using (var loadCmd = new MySqlCommand(loadQuery, conn))
                {
                    loadCmd.Parameters.AddWithValue("@jobDbId", job.Id);
                    using var loadReader = loadCmd.ExecuteReader();
                    while (loadReader.Read())
                    {
                        var load = new LoadDto
                        {
                            LoadId = loadReader.GetString("load_id"),
                            Description = loadReader.GetString("description"),
                            Volume = loadReader.GetDouble("volume"),
                            Weight = loadReader.GetDouble("weight")
                        };
                        loads.Add(load);
                    }
                }

                // Get transport units for the job
                var transportUnits = new List<TransportUnitDto>();
                string tuQuery = @"SELECT tu.id, tu.tu_id, tu.vehicle, tu.driver, tu.assistant, tu.available
                                   FROM job_transport_unit jtu
                                   JOIN transport_unit tu ON jtu.transport_unit = tu.id
                                   WHERE jtu.job = @jobDbId";
                
                using (var tuCmd = new MySqlCommand(tuQuery, conn))
                {
                    tuCmd.Parameters.AddWithValue("@jobDbId", job.Id);
                    using var tuReader = tuCmd.ExecuteReader();
                    while (tuReader.Read())
                    {
                        var available = Enum.TryParse<TransportUnitAvailableEnum>(tuReader.GetString("available"), out var availEnum) ? availEnum : TransportUnitAvailableEnum.NO;
                        var transportUnit = new TransportUnitDto
                        {
                            Id = tuReader.GetInt32("id"),
                            TuId = tuReader.GetString("tu_id"),
                            VehicleId = tuReader.GetInt32("vehicle"),
                            DriverId = tuReader.GetInt32("driver"),
                            AssistantId = tuReader.GetInt32("assistant"),
                            Available = available
                        };
                        transportUnits.Add(transportUnit);
                    }
                }

                // Assign Vehicle Registration Numbers to Transport Units
                foreach (var tu in transportUnits)
                {
                    string vehicleQuery = "SELECT registration_number FROM vehicle WHERE id = @vehicleId LIMIT 1";
                    using var vehicleCmd = new MySqlCommand(vehicleQuery, conn);
                    vehicleCmd.Parameters.AddWithValue("@vehicleId", tu.VehicleId);
                    var regNumber = vehicleCmd.ExecuteScalar() as string;
                    tu.VehicleRegistrationNumber = regNumber ?? string.Empty;
                }

                return new JobWithLoadsAndTransportUnitDto
                {
                    JobId = job.JobId,
                    CustomerId = customerCusId,
                    PickupLocation = job.PickupLocation,
                    DeliveryLocation = job.DeliveryLocation,
                    ScheduledDate = job.ScheduledDate,
                    EstimatedCost = job.EstimatedCost,
                    ActualCost = job.ActualCost,
                    Description = job.Description,
                    statusEnum = (JobStatusEnum)job.StatusId,
                    Loads = loads,
                    TransportUnits = transportUnits
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetJobWithLoadsAndTransportUnitsByJobId: {ex.Message}");
                throw new Exception($"Failed to retrieve job with loads and transport units for JobId: {jobId}", ex);
            }
        }

        public bool UpdateJobWithLoadsAndTransportUnitsByJobId(string jobId, JobWithLoadsAndTransportUnitDto dto)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            MySqlTransaction? transaction = null;
            
            try
            {
                transaction = conn.BeginTransaction();
                
                // Get job database ID
                int jobDbId;
                string getJobIdQuery = "SELECT id FROM job WHERE job_id = @jobId LIMIT 1";
                using (var getJobCmd = new MySqlCommand(getJobIdQuery, conn, transaction))
                {
                    getJobCmd.Parameters.AddWithValue("@jobId", jobId);
                    var result = getJobCmd.ExecuteScalar();
                    if (result == null)
                    {
                        throw new KeyNotFoundException($"Job with ID {jobId} not found.");
                    }
                    jobDbId = Convert.ToInt32(result);
                }
                
                // Update job table
                string updateJobQuery = @"UPDATE job SET pickup_location = @pickup, delivery_location = @delivery, 
                                          scheduled_date = @scheduledDate, estimated_cost = @estimatedCost, 
                                          actual_cost = @actualCost, description = @description, status = @status 
                                          WHERE job_id = @jobId";
                using (var updateJobCmd = new MySqlCommand(updateJobQuery, conn, transaction))
                {
                    updateJobCmd.Parameters.AddWithValue("@pickup", dto.PickupLocation);
                    updateJobCmd.Parameters.AddWithValue("@delivery", dto.DeliveryLocation);
                    updateJobCmd.Parameters.AddWithValue("@scheduledDate", dto.ScheduledDate);
                    updateJobCmd.Parameters.AddWithValue("@estimatedCost", dto.EstimatedCost.HasValue ? dto.EstimatedCost.Value : DBNull.Value);
                    updateJobCmd.Parameters.AddWithValue("@actualCost", dto.ActualCost.HasValue ? dto.ActualCost.Value : DBNull.Value);
                    updateJobCmd.Parameters.AddWithValue("@description", dto.Description ?? (object)DBNull.Value);
                    updateJobCmd.Parameters.AddWithValue("@status", (int)dto.statusEnum);
                    updateJobCmd.Parameters.AddWithValue("@jobId", jobId);
                    updateJobCmd.ExecuteNonQuery();
                }
                
                // Remove loads from RemvoedLoads list
                if (dto.RemvoedLoads != null && dto.RemvoedLoads.Count > 0)
                {
                    foreach (var removedLoad in dto.RemvoedLoads)
                    {
                        string deleteLoadQuery = "DELETE FROM `load` WHERE load_id = @loadId";
                        using var deleteLoadCmd = new MySqlCommand(deleteLoadQuery, conn, transaction);
                        deleteLoadCmd.Parameters.AddWithValue("@loadId", removedLoad.LoadId);
                        deleteLoadCmd.ExecuteNonQuery();
                    }
                }
                
                // Insert new loads from NewLoads list
                if (dto.NewLoads != null && dto.NewLoads.Count > 0)
                {
                    foreach (var newLoad in dto.NewLoads)
                    {
                        string insertLoadQuery = @"INSERT INTO `load` (load_id, description, volume, weight, job) 
                                                  VALUES (@loadId, @description, @volume, @weight, @jobDbId)";
                        using var insertLoadCmd = new MySqlCommand(insertLoadQuery, conn, transaction);
                        insertLoadCmd.Parameters.AddWithValue("@loadId", newLoad.LoadId);
                        insertLoadCmd.Parameters.AddWithValue("@description", newLoad.Description);
                        insertLoadCmd.Parameters.AddWithValue("@volume", newLoad.Volume);
                        insertLoadCmd.Parameters.AddWithValue("@weight", newLoad.Weight);
                        insertLoadCmd.Parameters.AddWithValue("@jobDbId", jobDbId);
                        insertLoadCmd.ExecuteNonQuery();
                    }
                }
                
                // Remove transport units from RemovedTransportUnits list
                if (dto.RemovedTransportUnits != null && dto.RemovedTransportUnits.Count > 0)
                {
                    foreach (var removedTU in dto.RemovedTransportUnits)
                    {
                        string deleteTUQuery = "DELETE FROM job_transport_unit WHERE job = @jobDbId AND transport_unit = @tuId";
                        using var deleteTUCmd = new MySqlCommand(deleteTUQuery, conn, transaction);
                        deleteTUCmd.Parameters.AddWithValue("@jobDbId", jobDbId);
                        deleteTUCmd.Parameters.AddWithValue("@tuId", removedTU.Id);
                        deleteTUCmd.ExecuteNonQuery();
                    }
                }
                
                // Insert new transport units from NewTransportUnits list
                if (dto.NewTransportUnits != null && dto.NewTransportUnits.Count > 0)
                {
                    foreach (var newTU in dto.NewTransportUnits)
                    {
                        string insertTUQuery = "INSERT INTO job_transport_unit (job, transport_unit) VALUES (@jobDbId, @tuId)";
                        using var insertTUCmd = new MySqlCommand(insertTUQuery, conn, transaction);
                        insertTUCmd.Parameters.AddWithValue("@jobDbId", jobDbId);
                        insertTUCmd.Parameters.AddWithValue("@tuId", newTU.Id);
                        insertTUCmd.ExecuteNonQuery();
                    }
                }
                
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                Console.WriteLine($"Error in UpdateJobWithLoadsAndTransportUnitsByJobId: {ex.Message}");
                throw new Exception($"Failed to update job with loads and transport units for JobId: {jobId}", ex);
            }
        }

        public List<JobModel> GetAllJobsByCustomerId(int? customerId)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            var jobs = new List<JobModel>();
            
            try
            {
                string query = @"SELECT id, job_id, pickup_location, delivery_location, scheduled_date, 
                                estimated_cost, actual_cost, status, customer, description, created_at 
                                FROM job WHERE customer = @customerId";
                
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                using var reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    var job = new JobModel(
                        reader.GetInt32("id"),
                        reader.GetString("job_id"),
                        reader.GetString("pickup_location"),
                        reader.GetString("delivery_location"),
                        reader.GetDateTime("scheduled_date"),
                        reader.IsDBNull(reader.GetOrdinal("estimated_cost")) ? null : reader.GetDouble("estimated_cost"),
                        reader.IsDBNull(reader.GetOrdinal("actual_cost")) ? null : reader.GetDouble("actual_cost"),
                        reader.GetInt32("status"),
                        reader.GetInt32("customer"),
                        reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description"),
                        reader.IsDBNull(reader.GetOrdinal("created_at")) ? DateTime.Now : reader.GetDateTime("created_at")
                    );
                    jobs.Add(job);
                }
                
                return jobs;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllJobsByCustomerId: {ex.Message}");
                throw new Exception($"Failed to retrieve jobs for customer ID: {customerId}", ex);
            }
        }

        public int GetTotalJobCount()
        {
            try
            {
                using var conn = DatabaseConnection.Instance.Connection;
                string query = "SELECT COUNT(*) FROM job";
                using var cmd = new MySqlCommand(query, conn);
                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetTotalJobCount: {ex.Message}");
                throw new Exception("Failed to get total job count", ex);
            }
        }

        public int GetTotalJobCountByStatus(int status)
        {
            try
            {
                using var conn = DatabaseConnection.Instance.Connection;
                string query = "SELECT COUNT(*) FROM job WHERE status = @status";
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", status);
                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetTotalJobCountByStatus: {ex.Message}");
                throw new Exception($"Failed to get job count for status {status}", ex);
            }
        }

        public List<JobModel> GetJobsBetweenCreatedAt(string startDate, string endDate)
        {
            try
            {
                using var conn = DatabaseConnection.Instance.Connection;
                var jobs = new List<JobModel>();
                string query = @"SELECT id, job_id, pickup_location, delivery_location, scheduled_date, 
                                estimated_cost, actual_cost, status, customer, description, created_at 
                                FROM job WHERE DATE(created_at) BETWEEN @startDate AND @endDate";
                
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                using var reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    var job = new JobModel(
                        reader.GetInt32("id"),
                        reader.GetString("job_id"),
                        reader.GetString("pickup_location"),
                        reader.GetString("delivery_location"),
                        reader.GetDateTime("scheduled_date"),
                        reader.IsDBNull(reader.GetOrdinal("estimated_cost")) ? null : reader.GetDouble("estimated_cost"),
                        reader.IsDBNull(reader.GetOrdinal("actual_cost")) ? null : reader.GetDouble("actual_cost"),
                        reader.GetInt32("status"),
                        reader.GetInt32("customer"),
                        reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description"),
                        reader.IsDBNull(reader.GetOrdinal("created_at")) ? DateTime.Now : reader.GetDateTime("created_at")
                    );
                    jobs.Add(job);
                }
                
                return jobs;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetJobsBetweenCreatedAt: {ex.Message}");
                throw new Exception($"Failed to get jobs between {startDate} and {endDate}", ex);
            }
        }
    }
}