using System.Transactions;

namespace CS303___05202024;

public class ClassForFunctionAndMethod
{

    //Fucntion
    // access modifier +  static(keyword)/non-static(hec bir keyword istifade edilmir) + return Type + function name + (qebul edeceyi parametr(ler))

    //Function adlandirmasi her zaman pascal case olmalidir.
    //function geriye deyer return ede de biler etmeye de biler
    //Functionin geriye qaytaracagi type evvelceden qeyd edilmelidir. ve ya geriye deyer qaytarmasa void keywordden istifade edilmelidir.


    //Functionun qebul etdiyini deyereler parametr adlanir.

    public int Toplama(int num1, int num2){

        int sum = num1 + num2;
        return sum;
    }

    //Car type object gelecek ve onun infosu ekrana cixarilacaq
    public void TestMethod(Car car)
    {
        //Get Info the car and show on the console

        Console.WriteLine($"Car Brand:{car.brand} model:{car.model}");

    }

    public void TestMethod2(int id,string brand,string model,int fuelCapacity,double currentFuel, double fuelFor1Km)
    {

        Car car = new Car()
        {
            brand = brand,
            model = model,
            fuelCapacity = fuelCapacity,
            currentFuel = currentFuel,
        };
    }

    #region HesablamaSimple
    public double Hesablama(double num1,double num2,char symb)
    {
        double answer = default;
        switch (symb)
        {
            case '+':

                answer= num1 + num2;
                break;
            case '-':

                answer = num1 - num2;
                break;
            case '*':

                answer = num1 * num2;
                break;
            case '/':

                answer = num1 / num2;
                break;

        }

        return answer;

    }

    #endregion

}
