using eshift.Dto;
using eshift.Enums;
using eshift.Service;
using eshift.Service.Impl;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace eshift.Controller.Impl
{
    internal class JobControllerImpl : IJobController
    {
        private readonly IJobService jobService;
        private readonly IVehicleController vehicleController;

        public JobControllerImpl()
        {
            jobService = new JobServiceImpl();
            vehicleController = new VehilceConrollerImpl();
        }

        public List<JobGridDto>? GetAllJobsForGrid()
        {
            return jobService.GetAllJobsForGrid();
        }

        public List<JobGridDto> GetJobRequestByStatus(JobStatusEnum status)
        {
            try
            {
                return jobService.GetJobByStatus(status);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public void DeleteJobByJobId(string jobId, JobStatusEnum status)
        {
            jobService.DeleteJobByJobId(jobId, status);
        }

        public void UpdateJob(string jobId, JobDto job)
        {
            jobService.UpdateJob(jobId, job);
        }

        public JobGridDto? GetJobForGridByJobId(string jobId)
        {
            return jobService.GetJobForGridByJobId(jobId);
        }

        public CustomerDto? GetCustomerById(string customerId)
        {
            return jobService.GetCustomerById(customerId);
        }

        public TransportUnitDto? GetTransportUnitById(string tuId)
        {
            return jobService.GetTransportUnitById(tuId);
        }

        public VehicleDto? GetVehicleById(int vehicleId)
        {
            return vehicleController.GetVehicleById(vehicleId);
        }

        public void CreateJob(CreateJobFormDto dto)
        {
            jobService.CreateJob(dto);
        }

        public List<JobGridDto> FilterJobByJobId(string jobId)
        {
            try
            {
                return jobService.FilterJobByJobId(jobId);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public JobWithLoadsDto? GetJobWithLoadsByJobId(string jobId)
        {
            try
            {
                return jobService.GetJobWithLoadsByJobId(jobId);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        public JobWithLoadsAndTransportUnitDto? GetJobWithLoadsAndTransportUnitsByJobId(string jobId)
        {
            try
            {
                return jobService.GetJobWithLoadsAndTransportUnitsByJobId(jobId);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        public bool UpdateJobStatusByJobId(string jobId, JobStatusEnum status)
        {
            try
            {
                return jobService.UpdateJobStatusByJobId(jobId, status);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public bool AcceptJobRequest(JobDto job)
        {
            try
            {
                return jobService.AcceptJobRequest(job);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public bool UpdateJobWithLoadsAndTransportUnitsByJobId(string jobId, JobWithLoadsAndTransportUnitDto dto)
        {
            try
            {
                return jobService.UpdateJobWithLoadsAndTransportUnitsByJobId(jobId, dto);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public List<JobGridDto> GetAllJobsForGridByCustomerId(string customerId)
        {
            try
            {
                return jobService.GetAllJobsForGridByCustomerId(customerId);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}