// See https://aka.ms/new-console-template for more information
Console.Clear(); //Will clear the console 
Console.WriteLine("Hello, World!");

//[Class name] [NameOfObject] = new [CLass name]();
Car carObj1 = new Car();


//Referencing class members within an object
int mile = carObj1.TotalDistancePerFuel();

carObj1.Sum(5, 10);

Console.WriteLine(mile);

Console.WriteLine("End of Method");
string owner = "Chadel";

Car carObj2 = new Car(owner);
Console.WriteLine(carObj2.Owner);
carObj2.Owner = "Daniel";
Console.WriteLine(carObj2.Owner);

carObj2.Fuel = 80;
Console.WriteLine(carObj2.Fuel);