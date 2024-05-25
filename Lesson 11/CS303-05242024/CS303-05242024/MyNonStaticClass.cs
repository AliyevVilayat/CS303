namespace CS303_05242024;

#region Class Members

//1.Field, 2.Property, 3.Constructor, 4.Method, 5.Index


//Instance class members - Bir başa olaraq object vasitəsi ilə bunlara müraciət edirəm


//Static və Non-static - Static class(lar) Static keyword ilə yazılır.
//Lakin Non-static heç bir keyword istifadə olmadan yazılır.
// Static olaraq təyin etdiyimiz class daxilində bütün memberlar static olmalıdır.
// Lakin Non-static class daxilində həm non-static yəni instance memberlar yer alır həm də static memberlar yer alır.

//Static constructor mütləq parameterless olmalıdır, access modifier olmamalıdır. Classa ilk müraciətdə işə düşəcək və bir daha əsla işə düşməyəcək.

#endregion

public class MyNonStaticClass
{
    private static int _counter;
    private string _name;
    public int Id
    {
        get; set;
    }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {

            _name = value;

        }
    }

    public MyNonStaticClass() //=> parameterless və ya default və ya boş constructor
    {
        _counter++;
        Id = _counter;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"ID:{Id}");
    }
}
