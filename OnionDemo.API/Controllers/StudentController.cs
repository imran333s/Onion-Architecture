using Application.DTOs;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnionDemo.API.Controllers
{
 [ApiController]
[Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly StudentService _service;
        public StudentsController(StudentService service) => _service = service;

        [HttpGet]
        public IActionResult Get() => Ok(_service.GetAllStudents());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = _service.GetStudentById(id);
            if (student == null) return NotFound();
            return Ok(student);
        }

        [HttpPost]
        public IActionResult Add([FromBody] StudentDTO dto)
        {
            _service.AddStudent(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] StudentDTO dto)
        {
            _service.UpdateStudent(id, dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteStudent(id);
            return Ok();
        }
    }

}
