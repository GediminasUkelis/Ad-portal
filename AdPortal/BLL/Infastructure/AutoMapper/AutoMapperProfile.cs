using AutoMapper;
using BLL.Dto;
using Domain.Models;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BLL.Infastructure.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Vehicle, VehicleDto>();

            CreateMap<ProductDto, Product>()
                .Include<VehicleDto, Vehicle>()
                .ForMember(x=>x.Id, s=>s.Ignore())
                .ForMember(x=>x.UserId, s=>s.Ignore())
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<VehicleDto, Vehicle>()
                .ForPath(x => x.CarDetails.Id, opt => opt.Ignore())
               
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CarDetails, CarDetailsDto>().ReverseMap();
            CreateMap<BikeDetails, BikeDetailsDto>().ReverseMap();
            CreateMap<User, RegisterDto>().ReverseMap();
            CreateMap<Image, ImageDto>().ReverseMap();
        }
    }
}