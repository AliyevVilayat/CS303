#region Notes

//var - anonym type, compile olaraq deyer menimsedilmesi edilir programin gedisatinda datatype deyisdirile bilmez. Declare edildiyi yerde deyer menisedilmelidir. Eks teqdirde compile time error alacayiq.

//object daxilindən data oxumaq üçün objectName + . + data(və ya variable və ya field, düzgün adlandırma FIELD'dır" example olaraq     string name = myObject.Name;


//object daxilindəki dataya yeni dəyər assing etmək üçün objectName + . + data(və ya variable və ya field, düzgün adlandırma FIELD'dır") + = + value         example olaraq    myObject.Name = "TestName"

#endregion


#region Switch Case Tips
/*
int statusCode = 222;
switch (statusCode)
{

    case 222:
    case 202:
    case 909:
    case 999:
    case 404:
        Console.WriteLine($"Emeliyyat ardicilligi {222}-202-909-999 ve sonda 404 icra edildi");
        //
        //
        break;

    case 100:
        Console.WriteLine();
        goto case 303;   // =>
        goto case 202;   // hec bir mena kesb etmir

    case 200:
        Console.WriteLine("Success.");
        //
        //
        goto case 404;

    case 303:

        Console.WriteLine("test");
        goto default;

    default:
        Console.WriteLine("bilinmeyen bir code");
        break;
}
*/
#endregion


#region var & dynamic
var variable = 5.5;

dynamic dynamicVariable = true;
dynamicVariable = 5;
dynamicVariable = "test";
dynamicVariable = 'a';
#endregion

#region OOP

/*int age = 23;
Console.WriteLine(age);
switch (age)
{
    case 23:
        Console.WriteLine("age:"+age);
        break;

    default:
        Console.WriteLine("Test function");
        break;
}*/

/*
 * Version 1
 * string name = "Mehemmed";
string surname = "Baxisov";
int age = 20;
string id = "S000001";

string name1 = "Kenan";
string surname1 = "Nabiyev";
int age1 = 20;
string id1 = "S000003";

string nameN = "Tural";
string surnameN = "Mensimli";
int ageN = 20;
string idN = "S00000N";
*/


//Version 2


var Mehemmed = new
{
    Name = "Mehemmed",
    Surname = "Baxışov",
    Age = 21,
};

var MehemmedEliyev = new
{
    Name = "Mehemmed",
    Surname = "Eliyev",
    Age = 22,

};

MehemmedEliyev.Age = 33;





Console.WriteLine("Telebe" + " " + MehemmedEliyev.Name + " " + MehemmedEliyev.Surname + " " + MehemmedEliyev.Age + " yaşındadır.");   // object + . + variable(eslinde field)

/* Id-e gore axtaris minimal example
Console.Write("Zehmet olmasa axtarmaq istediyiniz telebenin id-i qeyd edin: ");
string findId = Console.ReadLine();

//Switch daxilində dəyişənlər sadəcə hər bir şəxsə(student) görə sahib olduqları xüsusi datalar =>
switch (findId)
{
    case "S000001":
        Console.WriteLine($"Name:{name} Surname:{surname} Age:{age}");
        break;

    case "S000002":
        Console.WriteLine("Telebeye artiq xitam verilib");
        break;

    case "S000003":
        Console.WriteLine($"Name:{name1} Surname:{surname1} Age:{age1}");
        break;

    case "S00000N":
        Console.WriteLine($"Name:{nameN} Surname:{surnameN} Age:{ageN}");
        break;

    default:
        Console.WriteLine("Bele bir telebe movcud deyil");
        break;

}
Console.WriteLine();

*/


#endregion