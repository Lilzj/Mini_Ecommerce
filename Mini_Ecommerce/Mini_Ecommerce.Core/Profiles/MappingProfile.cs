using AutoMapper;
using Mini_Ecommerce.Entities.DTO.Request;
using Mini_Ecommerce.Entities.DTO.Response;
using Mini_Ecommerce.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Core.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerRequestDto, Customer>().ReverseMap();

            CreateMap<Customer, CustomerUpdateRequestDto>().ReverseMap();

            CreateMap<Address, AddressRequestDto>().ReverseMap();

            CreateMap<Address, AddressResponseDto>().ReverseMap();

            CreateMap<Order, OrderRequestDto>().ReverseMap();

            CreateMap<Customer, CustomerResponseDto>().ReverseMap();

            CreateMap<Order, OrderResponseDto>().ReverseMap();
        }
    }
}
