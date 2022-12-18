using lab6.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab6.Controllers
{
    [Route("api/Teachers")]
    public class TeachersController : Controller
    {
        private SchoolContext _context;

        public TeachersController(SchoolContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Teachers.AsEnumerable());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Teacher? teacher = _context.Teachers.FirstOrDefault();
            if(teacher == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(teacher);
            }
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Teacher? teacher = _context.Teachers.FirstOrDefault(t => t.Id == id);
            if(teacher == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(teacher);
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] Teacher teacher)
        {
            _context.Add(teacher);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] Teacher teacher)
        {
            _context.Update(teacher);
            _context.SaveChanges();
            return Ok();
        }
    }
}
