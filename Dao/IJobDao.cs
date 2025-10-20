using eshift.Model;
using System.Collections.Generic;
using eshift.Dto;

namespace eshift.Dao
{
    internal interface IJobDao
    {
        List<(JobModel, string, string, string)> GetAllJobsWithCustomerAndStatus();
        (JobModel, string, string, string)? GetJobWithCustomerAndStatusByJobId(string jobId);
        bool UpdateJobStatusByJobId(string jobId, int statusId);
        bool UpdateJob(string jobId, JobModel model);
        void CreateJob(string jobId, CreateJobFormDto dto, int statusId);
        List<JobModel> GetJobsByStatus(string status);
        List<JobModel> FilterJobsByJobId(string jobId);
        JobWithLoadsDto? GetJobWithLoadsByJobId(string jobId);
        JobWithLoadsAndTransportUnitDto? GetJobWithLoadsAndTransportUnitsByJobId(string jobId);
        bool UpdateJobWithLoadsAndTransportUnitsByJobId(string jobId, JobWithLoadsAndTransportUnitDto dto);
        List<JobModel> GetAllJobsByCustomerId(int? customerId);
        int GetTotalJobCount();
        int GetTotalJobCountByStatus(int status);

        List<JobModel> GetJobsBetweenCreatedAt(string startDate, string endDate);
    }
}