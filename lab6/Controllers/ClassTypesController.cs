using lab6.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab6.Controllers
{
    [Route("api/ClassTypes")]
    public class ClassTypesController : Controller
    {
        private SchoolContext _context;
        public ClassTypesController(SchoolContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.ClassTypes.AsEnumerable());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ClassType? type = _context.ClassTypes.FirstOrDefault(c => c.Id == id);
            if(type == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(type);
            }    
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            ClassType? type = _context.ClassTypes.FirstOrDefault(c => c.Id == id);
            if(type == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(type);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] ClassType type)
        {
            _context.Update(type);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult Create([FromBody] ClassType type)
        {
            _context.Add(type);
            _context.SaveChanges();
            return Ok();
        }
    }
}
