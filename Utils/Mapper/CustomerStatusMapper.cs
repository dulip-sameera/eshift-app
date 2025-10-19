using eshift.Model;
using eshift.Dto;

namespace eshift.Utils.Mapper
{
    internal class CustomerStatusMapper
    {
        public static CustomerStatusDto? ToDto(CustomerStatusModel model)
        {
            if (model == null) return null;
            return new CustomerStatusDto(model.Id, model.Name);
        }

        public static CustomerStatusModel? ToModel(CustomerStatusDto dto)
        {
            if (dto == null) return null;
            return new CustomerStatusModel(dto.Id, dto.Name);
        }
    }
}