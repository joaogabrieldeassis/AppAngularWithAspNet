using Microsoft.AspNetCore.Mvc;
using SmartScoolApi.Models.Interfaces;

namespace SmartScoolApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {       

        [HttpGet]
        public IActionResult GettAll()
        {
            return Ok("João");
        }
    }
}
