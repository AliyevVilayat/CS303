namespace CS303_21052024;

public class Car
{
    //Fields
    public int id;
    public string brand;
    public string model;



    //Constructor
    public Car()  //=> default constructor, boş constructor və ya parameterless constructor adlanır.
    {

    }

    //Method
    public void ShowInfo()
    {
        Console.WriteLine($"{id}'li {brand}'in {model} model avtomobili");
    }


}
