using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REPORTer.DAL.Entities;
using REPORTer.DAL.Repositories.Interfaces;

namespace REPORTer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IRepository<Group> _groupRepository;
        public GroupController(IRepository<Group> groupRepository)
        {
            _groupRepository = groupRepository;
        }
    }
}
