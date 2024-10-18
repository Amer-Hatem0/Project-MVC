using AutoMapper;
using dash.DAL.Models;
using dash.PL.Areas.Dashboard.ViewModels;

namespace dash.PL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {

            CreateMap<ServiceFromVM, Service>();
            CreateMap<Service, SerVM>();
            CreateMap<Service, SerAll>().ReverseMap(); 
            CreateMap<Serbin, SerAll>().ReverseMap();
          CreateMap<Service, ServiceBin>().ReverseMap();
            CreateMap<Service, Serbin>().ReverseMap();
          CreateMap<Serbin, ServiceBin>().ReverseMap();
            CreateMap<ServiceFromVM, ServiceBin>().ReverseMap();

            CreateMap<EmployeeFromVM, Employee>().ReverseMap();
            CreateMap<EmployeeIndex, Employee>().ReverseMap();
            CreateMap<Links, UpdatedLink>().ReverseMap(); 
            CreateMap<Blog, BlogIndex>().ReverseMap();
            CreateMap<Blog, Blogvm>().ReverseMap();

        }
    }
}
