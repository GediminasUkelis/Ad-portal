using AutoMapper;
using BLL.Dto;
using Domain.Models;
using System.Linq;

namespace BLL.Infastructure.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Vehicle, VehicleDto>();
            CreateMap<CarDetails, CarDetailsDto>().ReverseMap();
            CreateMap<BikeDetails, BikeDetailsDto>().ReverseMap();
            CreateMap<VehicleDto, Vehicle>()

                .ForMember(x => x.Id, opt => opt.Ignore())

                .ForPath(x => x.BikeDetails.Id, opt => opt.Ignore())
                .ForPath(x => x.CarDetails.Id, opt => opt.Ignore())
                .ForPath(x => x.User.Id, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<User, RegisterDto>();
            CreateMap<RegisterDto, User>();
            CreateMap<Image, ImageDto>().ReverseMap();
            CreateMap<User, UserDto>();
        }
    }
}