namespace CS303_05242024;

// => Non-static Class , Non-static Class daxilində həm Static həm də Non-static member(lar) təyin edə bilirəm

// => Static member    və non-static member uyğun olaraq
// non-instance member və instance member adlanır.


#region Method Signature


//Method signature => Method imzası bu şəkildədir: Methodun adı, Methodun qəbul etdiyi parametrlərin sayı,
//Methodun qəbul etdiyi parametrlərin ardıcıllığı və type'ı

//Method imzasına görə bu şərtlərdən heç olmasa biri fərqlilik göstərməsə eyni adda ikinci bir method yaratmaq olmaz.

//Methodun return typeı Method Signature aid deyil.

#endregion

public class MyCustomClass
{

    public int id;
    public readonly static string name;

    public int Number { get; set; }

    static MyCustomClass()
    {
        //id = 5; Static member daxilində non-static member istifadə edilə bilməz.
        name = "Test";
    }

    public string GetName(int num)
    {
        return name;
    }

    public string GetName2(int num) //=> ad dəyişdi
    {
        return name;
    }

    public string GetName(int num, string name)//=> parametrlərin sayı dəyişdi
    {
        return name;
    }

    public string GetName(string name,int num)//=> parametrlərin ardıcıllğı dəyişdi
    {
        return name;
    }

    public string GetName(string num) //=> parametrin typeı dəyişdi
    {
        return name;
    }


    public static int GetId()
    {
        //return id;
        return 5;
    }


}
