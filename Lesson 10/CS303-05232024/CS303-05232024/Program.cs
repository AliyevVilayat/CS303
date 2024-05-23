//Logical operators
//Console.ReadLine()

using CS303_05232024;
using System.Reflection;
/* And examples
Console.Write("Zehmet olmasa natural eded daxil edin:");
int num = Convert.ToInt32(Console.ReadLine());

if(num>0 && num % 2 == 0)
{
    Console.WriteLine("Eded cut ededdir");
}
else
{
    Console.WriteLine("Eded cut eded deyil");
}*/
#region Notes

//Logical operators

//&& - and (və)  verildiyi şərt daxilində hər iki tərəf yəni sol və sağ tərəf TRUE olduğu halda geriyə TRUE dəyər qaytarır

/* && - and
 * true + true = true +
 * true + false = false +
 * false + true = false +
 * false + false = false +
*/

// || - or(və ya) verildiyi şərt daxilində 2 tərəfdən heç olmasa biri TRUE olduğu halda TRUE dəyər geriyə qaytarır

/* || - or
 * true + true = true
 * true + false = true
 * false + true = true
 * false + false = false
*/

// ! - not(inkar) işləndiyi şərt daxilində əks dəyər qaytarır yəni TRUE dəyərin qarşısında FALSE , FALSE dəyərin qarşısında gələrsə TRUE dəyər qaytarır.

#endregion

#region Logical Operator's Examples

/*
Console.Write("Zehmet olmasa Muellimin adini qeyd edin:");
string name = Console.ReadLine();


if(name == "Vilayat")
{
    Console.WriteLine("Bu gun ders gunudur");
}
else if(name == "Togrul")
{
    Console.WriteLine("Bu gun lab gunudur");
}
else
{
    Console.WriteLine("Daxil edilen muellim bu qrupa ders demir");
}

*/
#endregion



/*Teacher teacher = new Teacher("Vilayat","Aliyev");
Console.WriteLine(teacher.seriaNumber);*/
/*Teacher teacher = new Teacher("AZE1234568")
{
    //Initialize

};
teacher.Name = "Togrul";
teacher.Surname = "Huseynli";
Console.WriteLine($"TeacherName:{teacher.Name}, SeriaNumber:{teacher.seriaNumber}" );
*/

//Console.WriteLine(Teacher.pin); => static movzusunda danisacayiq.



Assembly assembly = Assembly.GetExecutingAssembly();



Type myType = assembly.GetType("CS303_05232024.Teacher");
myType.Get
Console.WriteLine(myType.Name);