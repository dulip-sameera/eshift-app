using eshift.Model;
using eshift.Dto;

namespace eshift.Utils.Mapper
{
    internal class CustomerMapper
    {
        public static CustomerDto? ToDto(CustomerModel model)
        {
            if (model == null) return null;
            return new CustomerDto(
                model.Id,
                model.CusId,
                model.FirstName,
                model.LastName,
                model.Email,
                model.Phone,
                model.Address,
                model.City,
                model.ZipCode,
                new CustomerStatusDto(model.Status.Id, model.Status.Name),
                model.UserAccount
            );
        }

        public static CustomerModel? ToModel(CustomerDto dto)
        {
            if (dto == null) return null;
            return new CustomerModel(
                dto.Id,
                dto.CusId,
                dto.FirstName,
                dto.LastName,
                dto.Email,
                dto.Phone,
                dto.Address,
                dto.City,
                dto.ZipCode,
                new CustomerStatusModel(dto.Status.Id, dto.Status.Name),
                dto.UserAccount
            );
        }

        public static CustomerGridDto ToGridDto(CustomerModel model, string username)
        {
            if (model == null) return null!;
            return new CustomerGridDto(
                model.CusId,
                $"{model.FirstName} {model.LastName}".Trim(),
                model.Email,
                model.Phone,
                model.Address,
                model.City,
                model.ZipCode,
                model.Status?.Name ?? string.Empty,
                username ?? string.Empty
            );
        }
    }
}