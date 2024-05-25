namespace CS303_05242024;

public class Student
{

    public static int _counter;
    //private string _name;

    public static string Name
    {
        get;
        set;
    }

    public int Id { get; set; }

    static Student()
    {
        _counter = 1;
    }

    public Student()
    {
        Id = _counter;
        _counter++;
    }

    public Student(string name, string surname)
    {
        //_name = name;
        //_surname = surname;
    }

    public Student(string name, string surname, int age) : this(name, surname)
    {
        //_age = age;
    }

}


public static class Teacher
{
    public static int Id { get; set; }

    static Teacher()
    {
    }

    public static void StaticMethod()
    {

    }

}


