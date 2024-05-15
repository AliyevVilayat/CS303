
#region Variable Declaring
// Variable Declare, Variable Assign
// datatype variable = value
using System.ComponentModel.DataAnnotations;

string surname = "Aliyev";
#endregion

#region Name Convension
//Name Convension
string PascalCase = "VilayatAliyev";  //Pascal Case Istifade etmeli oldugumuz.
string camelCase = "vilayatAliyev"; //Camel Case
string snake_case = "vilayat_Aliyev"; //Snake Case
                                      //Kebab Case C# ucun uygun deyil. string full-name = "Vilayat-Aliyev"; 

string PascalCAse = "VilayatAliyev";
string _FullName = "VilayatAliyev";
//Eyni adda 2-ci bir dəyişən yarada bilmərəm.!!!!
//Variableın adının önündə simvol gəlməməlidir ( underline _ simvolundan basqa) .!!!!

Console.WriteLine(PascalCase);
Console.WriteLine(camelCase);
Console.WriteLine(snake_case);

#endregion

#region Datatype - Value Type

//Unsigned Numeric Types
byte numByte = 255;
ushort numUShort = 10000;
uint numUInt = 1000;
ulong numULong = 100000;

//Signed Numeric Types
sbyte numSByte = -127;
short numShort = -127;
int numInt = -127;
long numLong = -127;


//Floating-point Numeric types
float numFloat = 5.5F;
double numDouble = -5;

//High-precision decimal Floating-point Numeric types
decimal numDecimal = 5;

//Character types
char mySymbol = 'A';
char mySymbol2 = 'B';

//Char to numeric and numeric to char
int eded = 65;
char mySymbol3 = (char)eded;
int num = mySymbol3;

char defaultChar = default;
Console.WriteLine("------------------------");
Console.WriteLine(mySymbol);
Console.WriteLine(mySymbol3);

Console.WriteLine(num);


//Boolean
bool isVipUser = false;

#endregion

#region DataType - ReferenceType
#endregion

Console.WriteLine("                 ");


int number2 = 10 * 3;
int number3 = 10 + 3;
int number4 = 10 - 3;

int number = 10 / 3;   // 10 bolunsun 3 = tam 3 qaliq 1

int number5 = 10 % 3;


Console.WriteLine(number);
Console.WriteLine(number2);
Console.WriteLine(number3);
Console.WriteLine(number4);
Console.WriteLine(number5);


