namespace CS303_05222024;

//access modifier + static/non-static + ClassName (parameters)
//Default Constructor or Parameterless Constructor ve ya Bos konstruktor
//Private olaraq təyin olunan Class member yalnız təyin edildiyi edildiyi Class daxilində əlçatandır.
//Get və Set methoduna sahib olan Field, Property adlanır.

public class Student
{
    public int _id;
    public string _name;
    public string _surname;
    private int _age;

    public const string _pin = "12345AB";  // => const keywordü ilə biz təyin etdiyimiz property və ya filedlara təyin etdiyimiz dəyər assign etməliyik əks təqdirdə compiletime error verəcək


    public int Age
    {
        get
        {
            return _age;
        }

        set
        {
            if (value >= 0)
            {


                _age = value;
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }


    public Student()
    {
        _name = "Zamin";
        _surname = "Ismayilov";
        _age = 24;

    }

    public Student(string name, string surname) : this(0, name, surname, 99)
    {
        Console.WriteLine(_age);
        Console.WriteLine("From A");
    }

    public Student(int Id, string name, string surname, int age)
    {
        Console.WriteLine("From B");
        _id = Id;
        _name = name;
        _surname = surname;
        _age = age;

    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Telebenin haqqinda melumat:{_name}  {_surname}");

    }


    public int GetAge()
    {

        return _age;
    }

    public void SetAge(int age)
    {
        _age = age;
    }/**/
}


