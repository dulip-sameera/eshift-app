using eshift.Dto;
using eshift.Model;

namespace eshift.Utils.Mapper
{
    internal class StaffMapper
    {
        public static StaffDto ToDto(StaffModel model)
        {
            if (model == null) return null;
            return new StaffDto(
                id: model.Id,
                staffId: model.StaffId,
                firstName: model.FirstName,
                lastName: model.LastName,
                phone: model.Phone,
                email: model.Email,
                licenseNumber: model.LicenseNumber,
                type: new StaffTypeDto(model.Type.Id, model.Type.Name),
                userAccount: model.UserAccount,
                status: model.Status
            );
        }

        public static StaffModel ToModel(StaffDto dto)
        {
            return new StaffModel(
                0,
                dto.StaffId,
                dto.FirstName,
                dto.LastName,
                dto.Phone,
                dto.Email,
                dto.LicenseNumber,
                new StaffTypeModel(dto.Type.Id, dto.Type.Name),
                dto.UserAccount,
                dto.Status
            );
        }

        public static StaffGridDto ToGridDto(StaffModel model, string username)
        {
            return new StaffGridDto(
                model.StaffId,
                $"{model.FirstName} {model.LastName}".Trim(),
                model.Phone,
                model.Email,
                model.Type.Name,
                model.LicenseNumber,
                username,
                model.Status.ToString()
            );
        }

        public static List<StaffDto> ToDtoList(IEnumerable<StaffModel> models)
        {
            if (models == null) return new List<StaffDto>();
            return models.Select(ToDto).ToList();
        }

        public static List<StaffModel> ToModelList(IEnumerable<StaffDto> dtos)
        {
            if (dtos == null) return new List<StaffModel>();
            return dtos.Select(ToModel).ToList();
        }

        public static List<StaffGridDto> ToGridDtoList(IEnumerable<(StaffModel, string)> modelTuples)
        {
            if (modelTuples == null) return new List<StaffGridDto>();
            return modelTuples.Select(tuple => ToGridDto(tuple.Item1, tuple.Item2)).ToList();
        }
    }
}