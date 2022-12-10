namespace DotNetApi.Contracts;
public class StudentResponse
{
    public string name { get; private set; }
    public int id { get; private set; }
    public int age { get; private set; }

    public StudentResponse(int id, string name, int age)
    {
        this.id = id;
        this.name = name;
        this.age = age;
    }
}
