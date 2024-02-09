using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsAPI.Entities;
using StudentsAPI.Repositories;

namespace StudentsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(_studentService.GetAllStudents());
        }
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id) 
        {
            return Ok(_studentService.GetStudentById(id));
        }
        [HttpPost]
        public IActionResult AddStudent([FromBody] Student student)
        {
            _studentService.AddStudent(student);
            return Ok("Added succeesfully");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateStudent([FromBody] Student student,int id)
        {
            _studentService.UpdateStudent(student, id);
            return Ok("Updated successfully");
        }
        [HttpDelete]
         public IActionResult DeleteStudent(int id) 
        { 
            _studentService.DeleteStudent(id);
            return Ok("Deleted succeesfully");
        }

    }
}
