
#region DoWhile

int num = 10;

//Ön şərtli operator While
while (num < 10)                            // -> şərt hissə
{
    Console.WriteLine(num);
    num++;
}                                           // -> Icra edilen emeliyyat bloku


//Son şərtli operator Do While
do                                          // -> Icra edilen emeliyyat bloku
{
    Console.WriteLine(num);
    num++;

} while (num < 10);                         // -> şərt hissə


#endregion

#region For
for (int i = 0; i < 10; i += 2, num++)  // i = i+2;
{
    Console.Write(i);
    Console.Write(" ");
}

int j = 0;
while (j < 10)
{

    Console.WriteLine(j);
    j++;
}

#endregion


#region TaskInRoom1

//2. Verilmiş tam ədədin neçə mərtəbəsi olduğunu tapın. (Məs: input 123 - output 3 mərtəbəlidir).


//Algorithm
//123
//123 / 10 = 12 >0  count=1
//12 / 10 = 1 >0 count = 2
// 1/10 = 0 >0 count = 3


Console.WriteLine("--------------------------");
int eded = 1234;
int counter = 0;
while (eded > 0)
{
    Console.WriteLine(eded);
    eded = eded / 10;   // eded = 1234/10 = 123
    counter++;
}

Console.WriteLine("Mertebe sayi:" + counter);



//Algorithm 
//1234 - 4 1230/10

//1234 / 10 = 123
//1234 / 10 = 123,4

Console.WriteLine("---------------------------------");

int eded2 = 1234;
int eded2Copy = eded2;
int counter2 = 0;
while (eded2 > 0)
{
    eded2 = (eded2 - (eded2 % 10)) / 10;
    counter2++;
}

Console.WriteLine($"{eded2Copy}-in Mertebe sayi:{counter2}");

#endregion

#region TaskInRoom2

//3. Ədədin 3-ün qüvvətinin olub-olmamasını tapın.

Console.WriteLine("---------------------------");

int eded3 = 15;
int counterForPower = 0;
bool isPower = true;
while (eded3 > 1)
{
    if (eded3 % 3 == 0)
    {    
        counterForPower++;
    }
    else
    {
        Console.WriteLine("Eded 3-un quvveti deyil");
        isPower = false;
        break;      
    }

    eded3 = eded3 / 3;
}


if (isPower)
{
    Console.WriteLine($"Eded 3-un {counterForPower} dereceden quvvetidir");
}

#endregion