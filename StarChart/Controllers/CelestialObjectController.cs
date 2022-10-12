using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    [Route("")] [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CelestialObjectController(ApplicationDbContext context)
        {
            _context = context;

        }
        [HttpGet ("{id:int}")]
        public IActionResult GetById(int id)
        {
           return Ok(); 
        }
        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            return Ok();
        }
    }
}
