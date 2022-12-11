using Microsoft.AspNetCore.Mvc;
using DotNetApi.Contracts;
using DotNetApi.Services;
using DotNetApi.Models;
namespace DotNetApi.Controllers;

[ApiController]
[Route("Student")]
public class StudentContoller : ControllerBase
{
    private readonly ILogger<StudentContoller> _logger;
    private readonly IStudentService _studentService;

    public StudentContoller(ILogger<StudentContoller> logger, IStudentService _studentService)
    {
        _logger = logger;
        this._studentService = _studentService;
    }

    [HttpGet("{id}")]
    public StudentResponse GetStudent(int id)
    {
        this._logger.LogInformation("Get Received request");
        var Student = _studentService.GetStudent(id);
        return new StudentResponse(Student.Id, Student.Name, Student.Age);
    }

    [HttpPost()]
    public void SaveStudent(StudentRequest req)
    {
        this._logger.LogInformation("Post Received request");
        var Student = new Student(req.id, req.name, req.age);
        _studentService.SaveStudent(Student);
    }
}
