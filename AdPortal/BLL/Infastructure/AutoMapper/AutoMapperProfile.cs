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
             
                .ForPath(x => x.User.Id, opt => opt.Ignore())
             
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Tire, TireDto>();

            CreateMap<TireDto, Tire>()

                .ForMember(x => x.Id, opt => opt.Ignore())

                .ForPath(x => x.Condition.Id, opt => opt.Ignore())
                .ForPath(x => x.Condition.VehicCondition, opt => opt.MapFrom(input => input.Condition.VehicCondition))


                .ForPath(x => x.Diameter.Id, opt => opt.Ignore())
                .ForPath(x => x.Diameter.TireDiameter, opt => opt.MapFrom(input => input.Diameter.TireDiameter))

                .ForPath(x => x.Height.Id, opt => opt.Ignore())
                .ForPath(x => x.Height.TireHeight, opt => opt.MapFrom(input => input.Height.TireHeight))

                .ForPath(x => x.Manufacturer.Id, opt => opt.Ignore())
                .ForPath(x => x.Manufacturer.Name, opt => opt.MapFrom(input => input.Manufacturer.Name))

                .ForPath(x => x.Season.Id, opt => opt.Ignore())
                .ForPath(x => x.Season.SeasonName, opt => opt.MapFrom(input => input.Season.SeasonName))

                .ForPath(x => x.TirePurpose.Id, opt => opt.Ignore())
                .ForPath(x => x.TirePurpose.Name, opt => opt.MapFrom(input => input.TirePurpose.Name))

                .ForPath(x => x.Width.Id, opt => opt.Ignore())
                .ForPath(x => x.Width.TireWidth, opt => opt.MapFrom(input => input.Width.TireWidth))
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Motorbike, MotorbikeDto>();

            CreateMap<MotorbikeDto, Motorbike>()
                .ForMember(x => x.Id, opt => opt.Ignore())

                .ForPath(x => x.Manufacturer.Id, opt => opt.Ignore())
                .ForPath(x => x.Manufacturer.Name, opt => opt.MapFrom(input => input.Manufacturer.Name))

                .ForPath(x => x.Category.Id, opt => opt.Ignore())
                .ForPath(x => x.Category.Name, opt => opt.MapFrom(input => input.Category.Name))

                .ForPath(x => x.Condition.Id, opt => opt.Ignore())
                .ForPath(x => x.Condition.VehicCondition, opt => opt.MapFrom(input => input.Condition.VehicCondition))

                .ForPath(x => x.VehicleType.Id, opt => opt.Ignore())
                .ForPath(x => x.VehicleType.Type, opt => opt.MapFrom(input => input.VehicleType.Type))

                .ForPath(x => x.FuelType.Id, opt => opt.Ignore())
                .ForPath(x => x.FuelType.Type, opt => opt.MapFrom(input => input.FuelType.Type))

                .ForPath(x => x.Cooling.Id, opt => opt.Ignore())
                .ForPath(x => x.Cooling.CoolingType, opt => opt.MapFrom(input => input.Cooling.CoolingType))

                .ForPath(x => x.Defects.Id, opt => opt.Ignore())
                .ForPath(x => x.Defects.Defect, opt => opt.MapFrom(input => input.Defects.Defect))

            .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<User, RegisterDto>();

            CreateMap<RegisterDto, User>();
            CreateMap<Image, ImageDto>().ReverseMap();
           
            CreateMap<User, UserDto>();
        }
    }
}