using DotNetApi.Models;
namespace DotNetApi.Services;

public interface IStudentService
{
    void SaveStudent(Student student);
    Student GetStudent(int Id);
}