using AutoMapper;
using OOP_6.DAL;
using OOP_6.Models.DTO;

namespace OOP_6.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<UserUpdateDto, User>().ReverseMap();
        }
    }
}
