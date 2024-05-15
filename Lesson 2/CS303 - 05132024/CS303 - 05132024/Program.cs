


#region Qeydler
// datatype variableName = value

//CTRL + D => hemin setri asagi kopyalayir
//  CTRL + SHIFT + SLASH  => secdiyimiz linelari komment setre atir.

#endregion

#region Console Write
int sum = 5 + 10;
int num = 999;
/*Console.WriteLine("Cem = " + (sum + num));
Console.WriteLine("Cem = " + sum + 999);*/
/*
Console.WriteLine("10 + 5 = \n15");

int num1 = 10;
int num2 = 5;
Console.WriteLine(num1 + " + " + num2 + " = " + sum);

Console.WriteLine($"{num1} + {num2} = {sum}  bu bir text metnidir");

Console.WriteLine("1-ci setr");
Console.WriteLine("2-ci setr");
Console.Write("3-cu setr");
Console.Write(" 3-cu setrin davami");
Console.Write("test");*/

#endregion

//Ardi var..
#region Operators

//Hesab operatorlari

//toplama
int eded1 = 15;
int eded2 = 10;
int cem = eded1 + eded2;
Console.WriteLine($"{eded1} + {eded2} = {cem}");

int ferq = eded1 - eded2;
//uint ferq = (uint)eded1 - (uint)eded2;
//cixma
Console.WriteLine($"{eded1} - {eded2} = {ferq}");

int hasil = eded1 * eded2;
Console.WriteLine($"{eded1} * {eded2} = {hasil}");

int qismetDiv = eded1 / eded2;
Console.WriteLine($"{eded1} / {eded2} = {qismetDiv} (div bolme /)");

int qismetMod = eded1 % eded2;
Console.WriteLine($"{eded1} % {eded2} = {qismetMod} (mod bolme %)");


//Floating point

Console.WriteLine();


float qismetDivFloat = (float)eded1 / eded2;
Console.WriteLine($"{eded1} / {eded2} = {qismetDivFloat} (div bolme /)");

float qismetModFloat = (float)eded1 % (float)eded2;
Console.WriteLine($"{eded1} % {eded2} = {qismetModFloat} (mod bolme %)");

#region Increment

//Postfix Increment
int count = default;  // = 0

Console.WriteLine($"\n\n deyer: {count}");

count = count + 1; // count = 0 + 1

count += 1; // count = count + 1   => 1 + 1


count++; // => count = count + 1 => 2 + 1

Console.WriteLine("Count: " + count);


//Prefix Increment

++count; // count = count + 1;

Console.WriteLine("Count: " + count);

//Difference between postfix and prefix
Console.WriteLine("Postfix:" + count++); //loading count = count +1;
Console.WriteLine(count); //complate

Console.WriteLine("Prefix:" + ++count); // already complated
Console.WriteLine(count); //


count = 5;

//int answer = count++ + ++count; //5 + 7 
//int answer2 = count++ + count++ + count; // 5 + 6 + 7
int answer3 = ++count + ++count; // 6 + 7

Console.WriteLine("Correct answer is: " + answer3);

#endregion

#region Decrement

Console.WriteLine("Count: "+count);

/*
int answer4 = count--;
Console.WriteLine(answer5);
*/

/*int answer5 = --count;
Console.WriteLine(answer5);*/

//Count = 7
//int answer6 = --count + --count; // 11
int answer7 = --count + count-- + count; // 12+5 
//int answer8 = count-- +--count;

Console.WriteLine(answer7);

#endregion


//Assignment Operators
count += 10; // count = count + 10
count -= 10; // count = count + 10
count *= 10; // count = count + 10
count /= 10; // count = count + 10
count %= 10; // count = count + 10
#endregion

#region If serti operator

/*//If then condition
if (true)
{
    Console.WriteLine("If condition is true");

}

Console.WriteLine("Then");

//If Else condition

if (false)
{
    Console.WriteLine("If condition is true");

}
else
{
    Console.WriteLine("If condition is false");
}

Console.WriteLine("Then");
*/


// if then

int numTest = 100;

if (numTest < 0)
{
    Console.WriteLine("Menim ededim 0 dan kicik");
}

Console.WriteLine("Elaqesiz bir emeliyyat");


if(numTest > 99)
{
    Console.WriteLine("Eded 3 reqemlidir");
}
else
{
    Console.WriteLine("eded 100den kicikdir");
}


Console.WriteLine("Elaqesiz bir emeliyyat");


//Else if



#endregion