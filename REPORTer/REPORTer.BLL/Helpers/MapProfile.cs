using REPORTer.DTO.UserDTOs;
using AutoMapper;
using REPORTer.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPORTer.DAL.Helpers
{
    public class MapProfile : Profile
    {
       public MapProfile()
    {
            CreateMap<UserGetDTO, User>().ReverseMap();
            CreateMap<UserAddDTO, User>().ReverseMap();
        }
    }
}
