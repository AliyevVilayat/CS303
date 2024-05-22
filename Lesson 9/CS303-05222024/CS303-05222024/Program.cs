
using CS303_05222024;

#region Get Instance process
//Way 1
Student student = new Student()
{
    _name = "Test",
    _surname = "Testov"
};

student.DisplayInfo();

//Way 2
student._name = "Test2";
student._surname = "Testov2";
Console.WriteLine(student.GetAge());
student.DisplayInfo();


Student student2 = new Student(1,"ForConstructorName","ForConstructorSurname",33);

student2.DisplayInfo();

Student student3 = new Student("MyTestName","MyTestSurname");

#endregion

Console.WriteLine("-------------------------");

#region Properties
Student student1 = new Student();

student1.DisplayInfo();

student1._name = "Test";
Console.WriteLine(student1._name);


student1.Age = -25;
Console.WriteLine(student1.Age);



int age = student1.GetAge();
Console.WriteLine("Evellki yas:"+age); //=> Console.WriteLine(student1.GetAge());
/*
student1.SetAge(25);
Console.WriteLine("Hazirdaki yas:" + student1.GetAge()); */

#endregion