// See https://aka.ms/new-console-template for more information
using Day4;
using Day5;
using ModelHaven;

Console.WriteLine("Hello, World!");//Will write something in the terminal


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

//Checking if out property constraints is working
carObj2.Fuel = -100;
Console.WriteLine(carObj2.Fuel);

Car.Registration = true;

carObj1.GetRegistration();
carObj2.GetRegistration();

Car.Registration = false;

carObj1.GetRegistration();
carObj2.GetRegistration();

//Menu Demo
MainMenu menu = new MainMenu();
// bool repeat = true;

//Console.WriteLine("Hello! What is your name?");
//menuObj.Name = Console.ReadLine();

// while (repeat)
// {
//      menu.Display();
//      string ans = menu.Yourchoice();

//      if (ans == "MainMenu")
//      {
         
//      } 
//      else if (ans == "Select a model")
//      {

//      }
//      else if (ans == "Exit")
//      {
//          repeat = false;
//      } 
//         //  Console.Writeline("Your total price is " + menu.TotalPrice);
//         //  repeat = false;
// } 

// ModelHaven modelHavenObj = new ModelHaven();

Dictionary<string, int> _StoreMenu = new Dictionary<string, int>();


Collections collectObj = new Collections();
collectObj.CollectionsMain();

Conversions.ConversionsMain();

// Data.DataMain();

Serialization serialObj = new Serialization();
serialObj.SerializationMain();

Console.WriteLine("===OOP Demo===");
Dog dogobj = new Dog();
dogobj.Name = "Minnie";
dogobj.Talk();
dogobj.Run();
dogobj.Talk("Barking");
dogobj.Breed = "Chihuahua";

Animal aniobj = new Animal();
aniobj.Name = "McCoy";
//aniobj.Breed doesn't work because inheritance only works one way. Only the dog
aniobj.Health();

IAnimal aniobj2 = new Animal();
aniobj2.Health();