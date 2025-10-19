using eshift.Dto;
using eshift.Model;
using eshift.Enums;

namespace eshift.Utils.Mapper
{
    internal class TransportUnitMapper
    {
        public static TransportUnitModel? ToModel(TransportUnitDto dto)
        {
            if (dto == null) return null;
            return new TransportUnitModel(
                id: dto.Id,
                tuId: dto.TuId,
                vehicleId: dto.VehicleId,
                driverId: dto.DriverId,
                assistantId: dto.AssistantId,
                available: dto.Available
            );
        }

        public static TransportUnitDto? ToDto(TransportUnitModel model)
        {
            if (model == null) return null;
            return new TransportUnitDto(
                id: model.Id,
                tuId: model.TuId,
                vehicleId: model.VehicleId,
                driverId: model.DriverId,
                assistantId: model.AssistantId,
                available: model.Available
            );
        }

        // For grid mapping, you need to provide vehicle registration, staff info, etc.
        public static TransportUnitGridDto ToGridDto(
            TransportUnitModel model,
            string vehicleRegNo,
            string driverStaffId,
            string driverFirstName,
            string assistantStaffId,
            string assistantFirstName)
        {
            return new TransportUnitGridDto(
                transportUnitId: model.TuId,
                vehicle: vehicleRegNo,
                driver: $"{driverStaffId} : {driverFirstName}",
                assistant: $"{assistantStaffId} : {assistantFirstName}",
                available: model.Available == TransportUnitAvailableEnum.YES ? "Yes" : "No"
            );
        }

        public static List<TransportUnitModel> ToModelList(IEnumerable<TransportUnitDto> dtos)
        {
            if (dtos == null) return new List<TransportUnitModel>();
            return [.. dtos.Select(ToModel).Where(m => m != null)];
        }

        public static List<TransportUnitDto> ToDtoList(IEnumerable<TransportUnitModel> models)
        {
            if (models == null) return new List<TransportUnitDto>();
            return [.. models.Select(ToDto).Where(d => d != null)];
        }

        // List mapper for grid DTOs
        public static List<TransportUnitGridDto> ToGridDtoList(
            IEnumerable<TransportUnitModel> models,
            Func<TransportUnitModel, (string vehicleRegNo, string driverStaffId, string driverFirstName, string assistantStaffId, string assistantFirstName)> infoProvider)
        {
            if (models == null || infoProvider == null) return new List<TransportUnitGridDto>();
            var result = new List<TransportUnitGridDto>();
            foreach (var model in models)
            {
                var (vehicleRegNo, driverStaffId, driverFirstName, assistantStaffId, assistantFirstName) = infoProvider(model);
                result.Add(ToGridDto(model, vehicleRegNo, driverStaffId, driverFirstName, assistantStaffId, assistantFirstName));
            }
            return result;
        }
    }
}