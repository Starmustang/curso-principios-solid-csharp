using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{

    IStudentRepository studentRepository;

    ILogbook logbook;

    public StudentController(IStudentRepository student, ILogbook log)
    {
        studentRepository = student;
        logbook = log;
    }

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        logbook.Add($"returning student's list");
        return studentRepository.GetAll();
    }

    [HttpPost]
    public bool Add([FromBody] Student student)
    {
        try
        {
            studentRepository.Add(student);
            logbook.Add($"The Student {student.Fullname} have been added");
            return true;
        }
        catch (System.Exception)
        {

            return false;
        }
    }
}
