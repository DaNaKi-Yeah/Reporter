using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REPORTer.DAL.Entities;
using REPORTer.DAL.Repositories.Interfaces;

namespace REPORTer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IRepository<Report> _reportRepository;
        public ReportController(IRepository<Report> reportRepository)
        {
            _reportRepository = reportRepository;
        }
    }
}
