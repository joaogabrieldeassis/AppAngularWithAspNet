using Microsoft.AspNetCore.Mvc;

namespace SmartScoolApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("Espirito Santo");
        }
    }
}
