using CrmApi.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CrmApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize(Roles = "superadmin")]
    public class AuditLogsController : ControllerBase
    {
        private readonly CrmDbContext _context;

        public AuditLogsController(CrmDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllLogs()
        {
            var entityLogs = _context.EntityAuditLogs
                .OrderByDescending(x => x.Timestamp)
                .Take(100)
                .ToList();

            var requestLogs = _context.RequestAuditLogs
                .OrderByDescending(x => x.Timestamp)
                .Take(100)
                .ToList();

            return Ok(new
            {
                EntityLogs = entityLogs,
                RequestLogs = requestLogs
            });
        }
    }
}
