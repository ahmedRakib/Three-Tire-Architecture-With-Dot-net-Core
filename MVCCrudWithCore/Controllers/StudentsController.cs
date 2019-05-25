using App.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCCrudWithCore.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        IStudentService _studentService; 

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            //return new string[] { "value1", "value2" };

            var students = _studentService.GetAll();

            return Ok(students);
        }

    }
}
