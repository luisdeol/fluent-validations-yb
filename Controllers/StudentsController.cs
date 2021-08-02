using Microsoft.AspNetCore.Mvc;
using SchoolManager.API.Models;

namespace SchoolManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(AddStudentInputModel model) {
            return CreatedAtAction(nameof(Get), new { id = 1 }, model);
        } 
    }
}