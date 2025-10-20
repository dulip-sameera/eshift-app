using eshift.Dto;
using eshift.Model;
using eshift.Dao;
using eshift.Dao.Impl;
using eshift.Utils.Mapper;
using eshift.Enums;
using eshift.Utils.Generator;
using System.Collections.Generic;
using System;

namespace eshift.Service.Impl
{
    internal class JobServiceImpl : IJobService
    {
        private readonly IJobDao jobDao = new JobDaoImpl();
        private readonly ICustomerDao customerDao = new CustomerDaoImpl();
        private readonly ITransportUnitDao transportUnitDao = new TransportUnitDaoImpl();
        private readonly IVehicleDao vehicleDao = new VehicleDaoImpl();

        public List<JobGridDto>? GetAllJobsForGrid()
        {
            try
            {
                var jobTuples = jobDao.GetAllJobsWithCustomerAndStatus();
                if (jobTuples == null || jobTuples.Count == 0)
                    throw new KeyNotFoundException("No jobs found.");

                var gridDtos = new List<JobGridDto>();
                foreach (var tuple in jobTuples)
                {
                    var jobModel = tuple.Item1;
                    var customerCusId = tuple.Item2;
                    var customerFirstName = tuple.Item3;
                    var statusName = tuple.Item4;
                    gridDtos.Add(JobMapper.ToGridDto(jobModel, customerCusId, customerFirstName, statusName));
                }
                return gridDtos;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllJobsForGrid: {ex.Message}");
                throw;
            }
        }

        public List<JobGridDto> GetJobByStatus(JobStatusEnum status)
        {
            try
            {
                // Get jobs by status
                var jobs = jobDao.GetJobsByStatus(status.ToString());
                var jobGridList = new List<JobGridDto>();

                foreach (var job in jobs)
                {
                    // Get customer by ID
                    var customer = customerDao.GetCustomerById(job.CustomerId);
                    if (customer != null)
                    {
                        var jobGrid = new JobGridDto
                        {
                            JobID = job.JobId,
                            Customer = customer.CusId,
                            Pickup = job.PickupLocation,
                            Delivery = job.DeliveryLocation,
                            Description = job.Description,
                            ScheduledDate = job.ScheduledDate,
                            EstimatedCost = job.EstimatedCost,
                            ActualCost = job.ActualCost,
                            Status = status.ToString()
                        };
                        jobGridList.Add(jobGrid);
                    }
                }

                return jobGridList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetJobRequestByStatus: {ex.Message}");
                throw;
            }
        }

        public bool UpdateJobStatusByJobId(string jobId, JobStatusEnum status)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(jobId))
                {
                    throw new ArgumentException("Job ID cannot be empty.");
                }

                bool success = jobDao.UpdateJobStatusByJobId(jobId, (int)status);
                if (!success)
                {
                    throw new Exception("Failed to update job status.");
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateJobStatusByJobId: {ex.Message}");
                throw;
            }
        }

        public List<JobGridDto> FilterJobByJobId(string jobId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(jobId))
                {
                    return new List<JobGridDto>();
                }

                // Get filtered jobs by job ID
                var jobs = jobDao.FilterJobsByJobId(jobId);
                var jobGridList = new List<JobGridDto>();

                foreach (var job in jobs)
                {
                    // Get customer by ID
                    var customer = customerDao.GetCustomerById(job.CustomerId);
                    if (customer != null)
                    {
                        var jobGrid = new JobGridDto
                        {
                            JobID = job.JobId,
                            Customer = customer.CusId,
                            Pickup = job.PickupLocation,
                            Delivery = job.DeliveryLocation,
                            ScheduledDate = job.ScheduledDate,
                            EstimatedCost = job.EstimatedCost,
                            ActualCost = job.ActualCost,
                            Status = ((JobStatusEnum)job.StatusId).ToString()
                        };
                        jobGridList.Add(jobGrid);
                    }
                }

                return jobGridList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in FilterJobByJobId: {ex.Message}");
                throw;
            }
        }

        public JobWithLoadsDto? GetJobWithLoadsByJobId(string jobId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(jobId))
                {
                    throw new ArgumentException("Job ID cannot be empty.");
                }

                return jobDao.GetJobWithLoadsByJobId(jobId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetJobWithLoadsByJobId: {ex.Message}");
                throw;
            }
        }

        public JobWithLoadsAndTransportUnitDto? GetJobWithLoadsAndTransportUnitsByJobId(string jobId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(jobId))
                {
                    throw new ArgumentException("Job ID cannot be empty.");
                }
                return jobDao.GetJobWithLoadsAndTransportUnitsByJobId(jobId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetJobWithLoadsAndTransportUnitsByJobId: {ex.Message}");
                throw;
            }
        }

        public bool AcceptJobRequest(JobDto jobDto)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(jobDto.JobId))
                {
                    throw new ArgumentException("Job ID cannot be empty.");
                }

                // Get existing job
                var existingJobTuple = jobDao.GetJobWithCustomerAndStatusByJobId(jobDto.JobId);
                if (existingJobTuple == null)
                {
                    throw new Exception($"Job with ID {jobDto.JobId} not found.");
                }

                var existingJob = existingJobTuple.Value.Item1;
                
                // Update estimated cost and status
                existingJob.EstimatedCost = jobDto.EstimatedCost;
                existingJob.StatusId = (int)JobStatusEnum.ACCEPTED;

                // Update job in database
                bool success = jobDao.UpdateJob(jobDto.JobId, existingJob);
                if (!success)
                {
                    throw new Exception("Failed to accept job request.");
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AcceptJobRequest: {ex.Message}");
                throw;
            }
        }

        public List<JobGridDto> GetAllJobsForGridByCustomerId(string customerId)
        {
            try
            {
                // get the customer model
                var customerModel = customerDao.GetCustomerByCusId(customerId);
                if (customerModel == null)
                    throw new KeyNotFoundException("Customer not found.");
                int? customerDbId = customerModel.Id;

                // get all jobs for the customer
                var jobModels = jobDao.GetAllJobsByCustomerId(customerDbId);
                if (jobModels == null || jobModels.Count == 0)
                    throw new KeyNotFoundException("No jobs found for the customer.");

                // map to grid dtos
                var gridDtos = new List<JobGridDto>();
                foreach (var jobModel in jobModels)
                {
                    // get status name using JobStatusEnum
                    var statusName = ((JobStatusEnum)jobModel.StatusId).ToString();
                    gridDtos.Add(JobMapper.ToGridDto(jobModel, customerModel.CusId, customerModel.FirstName, statusName));
                }
                return gridDtos;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllJobsForGridByCustomerId: {ex.Message}");
                throw;
            }
        }

        public void DeleteJobByJobId(string jobId, JobStatusEnum status)
        {
            if (string.IsNullOrWhiteSpace(jobId))
                throw new ArgumentException("Job ID cannot be empty.");

            var tuple = jobDao.GetJobWithCustomerAndStatusByJobId(jobId);
            if (tuple == null)
                throw new KeyNotFoundException("Job not found for deletion.");

            bool updated = jobDao.UpdateJobStatusByJobId(jobId, (int)status);
            if (!updated)
                throw new Exception("Failed to delete (soft delete) job.");
        }

        public void UpdateJob(string jobId, JobDto job)
        {
            if (string.IsNullOrWhiteSpace(jobId))
                throw new ArgumentException("Job ID cannot be empty.");

            var tuple = jobDao.GetJobWithCustomerAndStatusByJobId(jobId);
            if (tuple == null)
                throw new KeyNotFoundException("Job not found for update.");

            var model = JobMapper.ToModel(job);
            bool updated = jobDao.UpdateJob(jobId, model);
            if (!updated)
                throw new Exception("Failed to update job.");
        }

        public JobGridDto? GetJobForGridByJobId(string jobId)
        {
            var tuple = jobDao.GetJobWithCustomerAndStatusByJobId(jobId);
            if (tuple == null) return null;
            var jobModel = tuple.Value.Item1;
            var customerCusId = tuple.Value.Item2;
            var customerFirstName = tuple.Value.Item3;
            var statusName = tuple.Value.Item4;
            return JobMapper.ToGridDto(jobModel, customerCusId, customerFirstName, statusName);
        }

        public CustomerDto? GetCustomerById(string customerId)
        {
            var customerModel = customerDao.GetCustomerByCusId(customerId);
            return customerModel != null ? CustomerMapper.ToDto(customerModel) : null;
        }

        public TransportUnitDto? GetTransportUnitById(string tuId)
        {
            var tuModel = transportUnitDao.GetTransportUnitByTuId(tuId);
            
            if (tuModel == null)
            {
                return null;
            }
            // get vehicle registration number
            var vehicleModel = vehicleDao.GetVehicleById(tuModel.VehicleId);
            if (vehicleModel != null)
            {
                return TransportUnitMapper.ToDto(tuModel, vehicleModel.RegistrationNumber);
            }
            else
            {
                return TransportUnitMapper.ToDto(tuModel);
            }
            
        }

        public void CreateJob(CreateJobFormDto dto)
        {
            // Generate job id
            string jobId = JobIdGenerator.GenerateNextJobId();
            // Determine initial status
            int statusId = 0;
            if (dto.Status.HasValue)
            {
                statusId = (int)dto.Status.Value;

            } else
            {
                statusId = dto.TransportUnits.Count > 0 ? (int)JobStatusEnum.IN_PROGRESS : (int)JobStatusEnum.ACCEPTED;
            }
                
            // Generate load ids
            foreach (var load in dto.Loads)
                load.LoadId = LoadIdGenerator.GenerateNextLoadId();
            jobDao.CreateJob(jobId, dto, statusId);
        }

        public bool UpdateJobWithLoadsAndTransportUnitsByJobId(string jobId, JobWithLoadsAndTransportUnitDto dto)
        {
            // generate new load ids for the new loads
            foreach (var load in dto.NewLoads)
            {
                load.LoadId = LoadIdGenerator.GenerateNextLoadId();
            }
            return jobDao.UpdateJobWithLoadsAndTransportUnitsByJobId(jobId, dto);
        }
    }
}