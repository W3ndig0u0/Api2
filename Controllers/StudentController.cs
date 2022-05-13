using Microsoft.AspNetCore.Mvc;

namespace Api2.Controllers
{
  [ApiController]
  [Route("student")]

  public class StudentController : ControllerBase
  {
    [HttpGet]
    public ActionResult GiveMeStudent()
    {
      Student student = new Student();
      student.Name = "Jing";
      student.FootSize = 40;
      student.ShirtSize = 'M';
      return Ok(student);

    }
  }
}