using Microsoft.AspNetCore.Mvc;
using DotNetApi.Contracts;
namespace DotNetApi.Controllers;

[ApiController]
[Route("Student/")]
public class StudentContoller : ControllerBase
{
   private readonly ILogger<StudentContoller> _logger;

    public StudentContoller(ILogger<StudentContoller> logger)
    {
        _logger = logger;
    }

    [HttpGet("{id}")]
    public StudentResponse GetStudent(int id)
    {
        this._logger.LogInformation("Received request");
        return new StudentResponse(1, "Student", 18);
    }
}
