using eshift.Dto;
using eshift.Enums;
using System.Collections.Generic;

namespace eshift.Service
{
    internal interface IJobService
    {
        List<JobGridDto>? GetAllJobsForGrid();
        List<JobGridDto> GetJobByStatus(JobStatusEnum status);
        List<JobGridDto> FilterJobByJobId(string jobId);
        JobWithLoadsDto? GetJobWithLoadsByJobId(string jobId);
        JobWithLoadsAndTransportUnitDto? GetJobWithLoadsAndTransportUnitsByJobId(string jobId);
        bool UpdateJobWithLoadsAndTransportUnitsByJobId(string jobId, JobWithLoadsAndTransportUnitDto dto);
        bool AcceptJobRequest(JobDto jobDto);
        bool UpdateJobStatusByJobId(string jobId, JobStatusEnum status);
        void DeleteJobByJobId(string jobId, JobStatusEnum status);
        void UpdateJob(string jobId, JobDto job);
        JobGridDto? GetJobForGridByJobId(string jobId);
        CustomerDto? GetCustomerById(string customerId);
        TransportUnitDto? GetTransportUnitById(string tuId);
        void CreateJob(CreateJobFormDto dto);
        List<JobGridDto> GetAllJobsForGridByCustomerId(string customerId);
    }
}