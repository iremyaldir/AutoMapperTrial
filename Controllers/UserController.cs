using AutoMapper;
using AutoMapperTrial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace AutoMapperTrial.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController: ControllerBase
    {
        private readonly IMapper _mapper;
        public UserController(IMapper mapper) 
        {
            _mapper = mapper;
        }
        [HttpGet]
        public UserInfoDTO Get()
        {
            var user = new User
            {
                Id=0,
                FirstName="irem",
                LastName="yaldır",
                Status = 2
            };
            
            var userInfo = _mapper.Map<UserInfoDTO>(user);
            return userInfo;
        }
    }
}
