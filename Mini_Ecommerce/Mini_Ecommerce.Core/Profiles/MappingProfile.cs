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
            CreateMap<CustomerRequestDto, Customer>()
                .ForMember(CustomerRequestDto => CustomerRequestDto.Address, x =>
                x.MapFrom(Customer => Customer.Address)).ReverseMap();

            CreateMap<Customer, CustomerUpdateRequestDto>().ReverseMap();

            CreateMap<Order, OrderRequestDto>().ReverseMap();

            CreateMap<Customer, CustomerResponse>()
                .ForMember(CustomerResponse => CustomerResponse.Address, x =>
                x.MapFrom(Customer => Customer.Address))
                .ForMember(CustomerResponse => CustomerResponse.Orders, x =>
                x.MapFrom(x => x.Orders));
        }
    }
}
