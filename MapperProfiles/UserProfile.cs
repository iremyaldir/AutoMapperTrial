using AutoMapper;
using AutoMapperTrial.Models;

namespace AutoMapperTrial.MapperProfiles
{
    public class UserProfile: Profile
    {
        public UserProfile() 
        {
            CreateMap<User, UserInfoDTO>()
                .ForMember(destination => destination.Name, operation =>operation.MapFrom(source => source.FirstName + " " + source.LastName))
                .ForMember(destination => destination.Status, operation => operation.MapFrom(source => ((UserStatusEnum)source.Status).ToString()));
        }

    }
}
