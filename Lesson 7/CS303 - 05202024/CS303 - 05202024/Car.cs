namespace CS303___05202024;

public class Car
{

    public int id;
    public string brand;
    public string model;
    public int fuelCapacity;
    public double fuelFor1Km;
    public double currentFuel;


    public Car()
    {

    }

    public void ShowInfo()
    {
        Console.WriteLine($"Car Brand:{brand} model:{model} Fuel Capacity:{fuelCapacity}");
    }
/* 

1.2. Car class (Car classı Vehicle-dan miras(Inheritence) alir)

 - Brand
 - Model
 - FuelCapacity
 - FuelFor1Km
 - CurrentFuel
 - ShowInfo() => method

 - Drive() -parametr olaraq maşının neçə km gedəcəyini qebul edir və əgər maşın o məsafəni gedə bilirsə maşının CurrentFuel dəyərini azaldır

 NOT: Brandi, Modeli, FuelFor1km, FuelCapacity təyin olunmamış Car obyekti instance almaq olmaz
*/
}
