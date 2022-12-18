using lab6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lab6.Controllers
{
    [Route("api/Classes")]
    public class ClassesController : Controller
    {
        private SchoolContext _context;
        public ClassesController(SchoolContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Classes.AsEnumerable());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Class? cls = _context.Classes.FirstOrDefault(c => c.Id == id);
            if (cls == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(cls);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Class? cls = _context.Classes.First(c => c.Id == id);
            if(cls == null)
            {
                return BadRequest();
            }
            else
            {
                _context.Classes.Remove(cls);
                _context.SaveChanges();
                return Ok();
            }
        }
        [HttpPost]
        public IActionResult Create([FromBody] Class cls)
        {
            _context.Classes.Add(cls);
            _context.SaveChanges();
            return Ok(cls);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Class cls)
        {
            _context.Classes.Update(cls);
            _context.SaveChanges();
            return Ok(cls);
        }
    }
}
