using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REPORTer.BLL.Services.Interfaces;
using REPORTer.DAL.Entities;
using REPORTer.DAL.Repositories.Interfaces;
using REPORTer.DTO.UserDTOs;

namespace REPORTer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        [Route("register")]
        public int Create(UserAddDTO user)
        {
            try
            {
                var Id = _userService.Create(user);
                return Id;
            }
            catch (Exception exeption)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("login")]
        public UserGetDTO Login(UserLoginDTO user)
        {
            try
            {
                UserGetDTO userEntity = _userService.GetByEmailAndPassword(user);

                return userEntity;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        [HttpGet]
        public UserGetDTO GetById(int id) 
        {
            try
            {
                var user = _userService.GetById(id);            
                return user;
            }
            catch (Exception exeption)
            {
                throw;
            }
        }
    }
}
