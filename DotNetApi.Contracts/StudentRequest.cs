namespace DotNetApi.Contracts;
public class StudentRequest
{
    public int id { get; set; }
    public string name { get; set; }
    public int age { get; set; }

    public StudentRequest(int id, string name, int age)
    {
        this.id = id;
        this.name = name;
        this.age = age;
    }
}
