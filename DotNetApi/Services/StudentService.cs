using DotNetApi.Models;
using System.Collections.Generic;
namespace DotNetApi.Services;

public class StudentService: IStudentService
{
    private static Dictionary<int, Student> _studentDict = new();
    public void SaveStudent(Student student)
    {
        _studentDict.Add(student.Id, student);
    }
    
    public Student GetStudent(int Id)
    {
        return _studentDict[Id];
    }
}
