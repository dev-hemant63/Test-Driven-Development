using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.DTO_s;
using Repository.Interfaces;

namespace TDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _student;
        public StudentController(IStudent student)
        {
            _student = student;
        }
        [HttpPost(nameof(Save))]
        public async Task<IActionResult> Save(StudentReq req)
        {
            return Ok(await _student.Save(req));
        }
    }
}
