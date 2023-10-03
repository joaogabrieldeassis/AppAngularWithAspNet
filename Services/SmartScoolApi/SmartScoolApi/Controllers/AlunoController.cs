using Microsoft.AspNetCore.Mvc;

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
