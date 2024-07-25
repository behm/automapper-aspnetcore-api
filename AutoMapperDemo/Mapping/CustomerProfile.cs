using AutoMapper;
using AutoMapperDemo.Data.Entities;
using AutoMapperDemo.Models;

namespace AutoMapperDemo.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerEntity, Customer>()
                .ForMember(d => d.Id, option => option.MapFrom(s => s.CustomerId))
                .ForMember(d => d.Notes, option => option.Ignore())
                ;
        }
    }
}
