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

StoreMenu customer = new StoreMenu();
customer.Menu();
bool repeat = true;
while (repeat)
{
    Console.WriteLine("What do you want to do?");
    string choice = Console.ReadLine();
    if (choice == "1")
    {
        
        Console.WriteLine(customer._totalPrice = customer._eggPrice + customer._totalPrice);
    }
    else if (choice == "2")
    {
        Console.WriteLine(customer._totalPrice = customer._milkPrice + customer._totalPrice);
    }
    else if (choice == "3")
    {
        Console.WriteLine(customer._totalPrice = customer._waterPrice + customer._totalPrice);
    }
    else if (choice == "4")
    {
        Console.WriteLine( " Your total is: " + customer._totalPrice);

        repeat = false;
    }
    
}

// //Menu Demo
// Menu menuObj = new Menu();
// bool repeat = true;

//         Console.WriteLine("Hello! What is your name?");
//         menuObj.Name = Console.ReadLine();

// while (repeat)
// {
//     menuObj.GreetUser();
//     string answer = Console.ReadLine();
//     if (answer == "1")
//     {
//         menuObj.BuyItem();
//     }
//     else if (answer == "2")
//     {
//         Console.WriteLine("Your total price is " + menuObj.totalPrice);
//         repeat = false;
//     }

// }

Collections collectObj = new Collections();
collectObj.CollectionsMain();

Conversions.ConversionsMain();

Collections storeitemsObj = new Collections();
storeitemsObj.CollectionsMain();

Collections shoppingCartObj = new Collections();
shoppingCartObj.CollectionsMain();