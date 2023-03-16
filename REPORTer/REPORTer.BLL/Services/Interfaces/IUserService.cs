using REPORTer.DAL.Entities;
using REPORTer.DTO.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPORTer.BLL.Services.Interfaces
{
    public interface IUserService
    {
        public int Create(UserAddDTO user);
        public UserGetDTO GetByEmailAndPassword(UserLoginDTO user);
        public UserGetDTO GetById(int Id);
    }
}
