#region Notes

//ctrl + k + d -> kodu duzenlemek ucun
//ctrl + shift + slash => secilen kod setrilerini kommente atir

#endregion

/*
//if - then
int num = 10;

Console.WriteLine("Emeliyyat 1");

if (num%2 == 0)
{
    Console.WriteLine("Emeliyyat 2");
    Console.WriteLine("Eded cut ededdir.");
}

Console.WriteLine("Emeliyyat 3");
*/



//Gonderilen ededin cut olub olmamasini yoxlayan proqrami tertib edin.
/*
int num = 9;
if(num%2 == 0)
{
    Console.WriteLine("Eded cut ededdir");
}
else {

    Console.WriteLine("Eded cut eded deyil");
}
//........

if (num <= 0)
{
    Console.WriteLine("Eded natural eded deyil");
}
else if(num%2 == 0)
{
    Console.WriteLine("Eded cut ededdir");
}
else
{
    Console.WriteLine("Eded tek ededdir");
}*/

//.......

#region Else If

int dayCode = 303;

if(dayCode == 1)
{
    Console.WriteLine("Bu gun bazar ertesidir");
}
else if(dayCode == 2)
{
    Console.WriteLine("Bu gun cersenbe axsamidir");
}

else if(dayCode == 7)
{
    Console.WriteLine("Bu gun bazar gunudur");
}

else
{
    Console.WriteLine("Gonderilen code gune aid deyil");
}
#endregion

#region Switch Case
//Deyere gore yoxlanis aparan zaman ona uygun emeliyyatlari icra etmek ucun Else If evezinde, Switch Case istifade etmek meqsede daha uygundur.

switch (dayCode)
{
    case 1:
        Console.WriteLine("Test emeliyyat");
        Console.WriteLine("Bu gun bazar ertesidir");
        break;

    case 2:

        Console.WriteLine("Test emeliyyat");
        Console.WriteLine("Cersenbe axsami");
        break;

    case 3:
        Console.WriteLine("Cersenbe");
        break;

    case 7:
        Console.WriteLine("Bazar gunu");
        break;

    case 8:
        Console.WriteLine("Bu gun 8ci gundur");
        break;

    default:
        Console.WriteLine("Gonderilen code gune aid deyil");
        break;
}


#endregion

#region Switch Case Expression
string result = dayCode switch
{

    7 => "Bazar",
    >=91 and <=100 => "A",
    _ => "Cyber Security Group N"

};

Console.WriteLine(result);
#endregion


#region While


//Gonderilen musbet ededden => num'a qarsiliq gelir

//0-a qeder olan butun natural ededleri => ne qeder ki num 0'dan boyukdur

//mene cap ele =>  Console.WriteLine(num);

int num = 10;
while (num > 0)
{

    num--;

    if(num == 5)
    {
        break; 
    }
    else
    {
        Console.Write(num + " ");
    }

    Console.WriteLine("Test");
}

Console.WriteLine("While bitdi");

#endregion