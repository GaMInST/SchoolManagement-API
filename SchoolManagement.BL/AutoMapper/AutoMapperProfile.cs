using AutoMapper;
using SchoolMangementDAL.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Student, StudentCreateVm>().ReverseMap();
        CreateMap<Student, StudentDetailsVm>().ReverseMap();
        CreateMap<Student, StudentUpdateVm>().ReverseMap();

        CreateMap<Course, CourseVm>().ReverseMap();
        CreateMap<Course, CourseDetailsVm>().ReverseMap();
    }
}
