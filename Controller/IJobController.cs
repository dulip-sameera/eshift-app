using eshift.Dto;
using eshift.Enums;
using System.Collections.Generic;

namespace eshift.Controller
{
    internal interface IJobController
    {
        List<JobGridDto>? GetAllJobsForGrid();
        List<JobGridDto> GetJobRequestByStatus(JobStatusEnum status);
        List<JobGridDto> FilterJobByJobId(string jobId);
        JobWithLoadsDto? GetJobWithLoadsByJobId(string jobId);
        bool AcceptJobRequest(JobDto jobDto);
        bool UpdateJobStatusByJobId(string jobId, JobStatusEnum status);
        void DeleteJobByJobId(string jobId, JobStatusEnum status);
        void UpdateJob(string jobId, JobDto job);
        JobGridDto? GetJobForGridByJobId(string jobId);
        CustomerDto? GetCustomerById(string customerId);
        TransportUnitDto? GetTransportUnitById(string tuId);
        VehicleDto? GetVehicleById(int vehicleId);
        void CreateJob(CreateJobFormDto dto);
    }
}