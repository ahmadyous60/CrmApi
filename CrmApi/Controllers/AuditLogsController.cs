using CrmApi.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CrmApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "superadmin")]  // ✅ only superadmins can access logs
    public class AuditLogsController : ControllerBase
    {
        private readonly CrmDbContext _context;

        public AuditLogsController(CrmDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetLogs()
        {
            var logs = _context.AuditLogs
                .OrderByDescending(x => x.Timestamp)
                .Take(200)
                .ToList();

            return Ok(logs);
        }
    }
}
