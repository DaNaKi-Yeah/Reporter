using AutoMapper;
using REPORTer.BLL.Services.Interfaces;
using REPORTer.DAL.Entities;
using REPORTer.DAL.Enums;
using REPORTer.DAL.Repositories.Interfaces;
using REPORTer.DTO.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPORTer.BLL.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IMapper _mapper;
        public UserService(IRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public int Create(UserAddDTO user)
        {
            if (user is null)
            {
                throw new Exception("Invalid object for creating");
            }

            var userEntity = _mapper.Map<User>(user);

            SetDefaultRoles(userEntity);

            _userRepository.Add(userEntity);
            return userEntity.Id;
        }

        public UserGetDTO GetByEmailAndPassword(UserLoginDTO userLoginDTO)
        {
            string userEmail = userLoginDTO.Email;
            string userPassword = userLoginDTO.Password;

            List<User> users = _userRepository.GetAll();

            foreach (User user in users)
            {
                if (user.Email == userEmail)
                {
                    if (user.Password == userPassword)
                    {
                        return _mapper.Map<UserGetDTO>(user);
                    }
                    else
                    {
                        throw new Exception("Invalid password");
                    }
                }
            }
            throw new Exception("Not found user");
        }

        public UserGetDTO GetById(int Id)
        {
            var userEntity = _userRepository.GetById(Id);
            if (userEntity is null)
            {
                throw new Exception("Entity with given id does not exist");
            }
            return _mapper.Map<UserGetDTO>(userEntity);
        }

        private void SetDefaultRoles(User user)
        {
            user.RoleInGroup = RoleInGroup.None;
            user.RoleInReporter = RoleInReporter.User;
        }
    }
}
