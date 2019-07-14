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
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_userService.GetUsers());
        }

        // GET api/values/5
        [HttpGet("{id:length(24)}")]
        public ActionResult<string> GetUser(string id)
        {
            var user = _userService.GetUser(id);
            if (user == null) return NotFound();
            return Ok(user);
        }
    }
}
