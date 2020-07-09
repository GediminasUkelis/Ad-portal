using AutoMapper;
using BLL.Dto;
using Domain.Models;

namespace BLL.Infastructure.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Car, CarDto>();

            CreateMap<CarDto, Car>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForPath(x => x.Color.Id, opt => opt.Ignore())
                .ForPath(x => x.Color.Name, opt => opt.MapFrom(input => input.Color.Name))

                .ForPath(x => x.Category.Id, opt => opt.Ignore())
                .ForPath(x => x.Category.Name, opt => opt.MapFrom(input => input.Category.Name))

                .ForPath(x => x.Defects.Id, opt => opt.Ignore())
                .ForPath(x => x.Defects.Defect, opt => opt.MapFrom(input => input.Defects.Defect))

                .ForPath(x => x.Manufacturer.Id, opt => opt.Ignore())
                .ForPath(x => x.Manufacturer.Name, opt => opt.MapFrom(input => input.Manufacturer.Name))

                .ForPath(x => x.ManufacturerModel.Id, opt => opt.Ignore())
                .ForPath(x => x.ManufacturerModel.Name, opt => opt.MapFrom(input => input.ManufacturerModel.Name))

                .ForPath(x => x.FuelType.Id, opt => opt.Ignore())
                .ForPath(x => x.FuelType.Type, opt => opt.MapFrom(input => input.FuelType.Type))

                .ForPath(x => x.FrameType.Id, opt => opt.Ignore())
                .ForPath(x => x.FrameType.Type, opt => opt.MapFrom(input => input.FrameType.Type))

                .ForPath(x => x.Transmission.Id, opt => opt.Ignore())
                .ForPath(x => x.Transmission.Type, opt => opt.MapFrom(input => input.Transmission.Type))

                .ForPath(x => x.SteeringWheelPos.Id, opt => opt.Ignore())
                .ForPath(x => x.SteeringWheelPos.Position, opt => opt.MapFrom(input => input.SteeringWheelPos.Position))

                .ForPath(x => x.Doors.Id, opt => opt.Ignore())
                .ForPath(x => x.Doors.DoorCount, opt => opt.MapFrom(input => input.Doors.DoorCount))

                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}