using CS303_05242024;

MyCustomClass myCustomObj = new (); // => C# 9'dan sonra bu yazılışdan istifadə etməyib MyCustomClass myCustomObj = new MyCustomClass(); sadəcə new keywordu yazıb bitiririk.

Console.WriteLine(myCustomObj.id);
Console.WriteLine(MyCustomClass.name);

//myCustomObj.GetName();
MyCustomClass.GetId();