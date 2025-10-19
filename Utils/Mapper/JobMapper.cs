using eshift.Dto;
using eshift.Model;
using eshift.Enums;
using System;

namespace eshift.Utils.Mapper
{
    internal class JobMapper
    {
        public static JobDto ToDto(JobModel model)
        {
            if (model == null) return null;
            return new JobDto(
                id: model.Id,
                jobId: model.JobId,
                pickupLocation: model.PickupLocation,
                deliveryLocation: model.DeliveryLocation,
                scheduledDate: model.ScheduledDate,
                estimatedCost: model.EstimatedCost,
                actualCost: model.ActualCost,
                statusId: model.StatusId,
                customerId: model.CustomerId,
                description: model.Description
            );
        }

        public static JobModel ToModel(JobDto dto)
        {
            if (dto == null) return null;
            return new JobModel(
                id: dto.Id,
                jobId: dto.JobId,
                pickupLocation: dto.PickupLocation,
                deliveryLocation: dto.DeliveryLocation,
                scheduledDate: dto.ScheduledDate,
                estimatedCost: dto.EstimatedCost,
                actualCost: dto.ActualCost,
                statusId: dto.StatusId,
                customerId: dto.CustomerId,
                description: dto.Description
            );
        }

        public static JobGridDto ToGridDto(JobModel model, string customerCusId, string customerFirstName, string statusName)
        {
            return new JobGridDto(
                jobID: model.JobId,
                customer: $"{customerCusId} : {customerFirstName}",
                pickup: model.PickupLocation,
                delivery: model.DeliveryLocation,
                description: model.Description,
                scheduledDate: model.ScheduledDate,
                estimatedCost: model.EstimatedCost,
                actualCost: model.ActualCost,
                status: statusName
            );
        }

        public static JobStatusDto ToStatusDto(JobStatusModel model)
        {
            if (model == null) return null;
            return new JobStatusDto(model.Id, model.Name);
        }

        public static JobStatusModel ToStatusModel(JobStatusDto dto)
        {
            if (dto == null) return null;
            return new JobStatusModel(dto.Id, dto.Name);
        }

        public static JobTransportUnitDto ToTransportUnitDto(JobTransportUnitModel model)
        {
            if (model == null) return null;
            return new JobTransportUnitDto(model.Id, model.JobId, model.TransportUnitId);
        }

        public static JobTransportUnitModel ToTransportUnitModel(JobTransportUnitDto dto)
        {
            if (dto == null) return null;
            return new JobTransportUnitModel(dto.Id, dto.JobId, dto.TransportUnitId);
        }

        public static LoadDto ToLoadDto(LoadModel model)
        {
            if (model == null) return null;
            return new LoadDto(model.Id, model.LoadId, model.Description, model.Volume, model.Weight, model.JobId);
        }

        public static LoadModel ToLoadModel(LoadDto dto)
        {
            if (dto == null) return null;
            return new LoadModel(dto.Id, dto.LoadId, dto.Description, dto.Volume, dto.Weight, dto.JobId);
        }
    }
}