using Microsoft.AspNetCore.Mvc;
using System;

namespace AKSExample.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MachineController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Environment.MachineName);
        }
    }
}
