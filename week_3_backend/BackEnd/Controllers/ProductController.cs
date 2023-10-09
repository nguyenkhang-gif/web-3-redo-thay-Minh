using BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        public ProductController(DatabaseContext context)
        {
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
        [HttpGet("[action]/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok();
        }
        [HttpPost("[action]")]
        public async Task<ActionResult> Insert([FromBody] Sach sach)
        {
            return Ok();
        }
    }
}