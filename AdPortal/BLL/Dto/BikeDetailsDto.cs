using Domain.Models.Enums;

namespace BLL.Dto
{
    public class BikeDetailsDto : BaseModelDto
    {
        public Enumerators.BikeType BikeType { get; set; }
    }
}