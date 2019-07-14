using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionsController : ControllerBase
    {
        private readonly ISessionService _sessionService;

        public SessionsController(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get([FromQuery] bool? active)
        {
            return Ok(_sessionService.GetSessions(active));
        }

        [HttpGet("report")]
        public ActionResult<string> GetRevenueByMonth(string id)
        {
            var session = _sessionService.GetSession(id);
            if (session == null) return NotFound();
            return Ok(session);
        }

        [HttpGet("report/{lotId}")]
        public ActionResult<string> GetSessionReportForLot(string lotId)
        {
            return Ok();
        }

        // GET api/values/5
        [HttpGet("{id:length(24)}")]
        public ActionResult<string> GetSession(string id)
        {
            return Ok();
        }
    }
}
