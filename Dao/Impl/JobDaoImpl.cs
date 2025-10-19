using eshift.Database;
using eshift.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using eshift.Dto;
using System;

namespace eshift.Dao.Impl
{
    internal class JobDaoImpl : IJobDao
    {
        public List<(JobModel, string, string, string)> GetAllJobsWithCustomerAndStatus()
        {
            var list = new List<(JobModel, string, string, string)>();
            var conn = DatabaseConnection.Instance.Connection;
            string query = @"SELECT j.id, j.job_id, j.pickup_location, j.delivery_location, j.scheduled_date, j.estimated_cost, j.actual_cost, j.status, j.customer, j.description,
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
                    reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description")
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
            var conn = DatabaseConnection.Instance.Connection;
            string query = @"SELECT j.id, j.job_id, j.pickup_location, j.delivery_location, j.scheduled_date, j.estimated_cost, j.actual_cost, j.status, j.customer, j.description,
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
                    reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description")
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
            var conn = DatabaseConnection.Instance.Connection;
            string query = "UPDATE job SET status = @statusId WHERE job_id = @jobId";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@statusId", statusId);
            cmd.Parameters.AddWithValue("@jobId", jobId);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool UpdateJob(string jobId, JobModel model)
        {
            var conn = DatabaseConnection.Instance.Connection;
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
            var conn = DatabaseConnection.Instance.Connection;
            using var transaction = conn.BeginTransaction();
            try
            {
                // Insert job
                string jobQuery = @"INSERT INTO job (job_id, pickup_location, delivery_location, scheduled_date, estimated_cost, status, customer, description) VALUES (@jobId, @pickup, @delivery, @scheduledDate, @estimatedCost, @status, @customer, @description)";
                using var jobCmd = new MySqlCommand(jobQuery, conn, transaction);
                jobCmd.Parameters.AddWithValue("@jobId", jobId);
                jobCmd.Parameters.AddWithValue("@pickup", dto.Pickup);
                jobCmd.Parameters.AddWithValue("@delivery", dto.Delivery);
                jobCmd.Parameters.AddWithValue("@scheduledDate", dto.ScheduledDate);
                jobCmd.Parameters.AddWithValue("@estimatedCost", dto.EstimatedCost);
                jobCmd.Parameters.AddWithValue("@status", statusId);
                jobCmd.Parameters.AddWithValue("@customer", dto.CustomerId);
                jobCmd.Parameters.AddWithValue("@description", dto.Description ?? (object)DBNull.Value);
                jobCmd.ExecuteNonQuery();
                // Get inserted job DB id
                int jobDbId = 0;
                using (var idCmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn, transaction))
                {
                    jobDbId = Convert.ToInt32(idCmd.ExecuteScalar());
                }
                // Insert loads
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
                // Insert job_transport_unit
                foreach (var tu in dto.TransportUnits)
                {
                    string jtQuery = @"INSERT INTO job_transport_unit (job, transport_unit) VALUES (@job, @tu)";
                    using var jtCmd = new MySqlCommand(jtQuery, conn, transaction);
                    jtCmd.Parameters.AddWithValue("@job", jobDbId);
                    jtCmd.Parameters.AddWithValue("@tu", tu.Id);
                    jtCmd.ExecuteNonQuery();
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
            var conn = DatabaseConnection.Instance.Connection;
            string query = @"SELECT j.id, j.job_id, j.pickup_location, j.delivery_location, j.scheduled_date, j.estimated_cost, j.actual_cost, j.status, j.customer, j.description
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
                        reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description")
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
            var conn = DatabaseConnection.Instance.Connection;
            string query = @"SELECT j.id, j.job_id, j.pickup_location, j.delivery_location, j.scheduled_date, j.estimated_cost, j.actual_cost, j.status, j.customer, j.description
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
                        reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description")
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
            var conn = DatabaseConnection.Instance.Connection;
            try
            {
                // First get the job with customer CusId
                JobModel? job = null;
                string customerCusId = string.Empty;
                string jobQuery = @"SELECT j.id, j.job_id, j.pickup_location, j.delivery_location, j.scheduled_date, j.estimated_cost, j.actual_cost, j.status, j.customer, j.description, c.cus_id
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
                            jobReader.IsDBNull(jobReader.GetOrdinal("description")) ? null : jobReader.GetString("description")
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
    }
}