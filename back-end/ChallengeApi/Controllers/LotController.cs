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
    public class LotsController : ControllerBase
    {
        private readonly ILotService _lotService;

        public LotsController(ILotService lotService)
        {
            _lotService = lotService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_lotService.GetLots());
        }

        // GET api/values/5
        [HttpGet("{id:length(24)}")]
        public ActionResult<string> GetLot(int id)
        {
            throw new NotImplementedException("Need to implement get method for a Lot.");
        }
    }
}
