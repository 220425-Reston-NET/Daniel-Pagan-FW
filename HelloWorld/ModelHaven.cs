public class ModelHaven
{
    private int _BreakerPrice;
    private int _BarbatosPrice;
    private int _AstraeaPrice;
    private int _SchwarzritterPrice;
    private int _PhoenixPrice;
    private int _totalPrice;
   
   Console.WriteLine("===Store Menu===");
    {
        _Breaker.Add("Breaker",26);
        _Barbatos.Add(52);
        _Astraea.Add(69);
        _Schwarzritter.Add(149);
        _Phoenix.Add(2754);
    }

    public void Greeting()
    {
        Console.Clear();
        Console.WriteLine("What model are you interested in today?");
        Console.WriteLine("1. Buy an item");
        Console.WriteLine("2. Checkout");
    }

    public void BuyItem()
    {
        bool repeat = true;
        while (repeat)

        Console.WriteLine("1 - Breaker $" + _BreakerPrice);
        Console.WriteLine("2 - Barbatos $" + _BarbatosPrice);
        Console.WriteLine("3 - Astraea $" + _AstraeaPrice);
        Console.WriteLine("4 - Schwarzritter $" + _SchwarzritterPrice);
        Console.WriteLine("5 - Phoenix $" + _PhoenixPrice);
        string answer = Console.ReadLine();
        if (answer == "1")
        {
            _totalPrice += _BreakerPrice;
        }
        if (answer == "2")
        {
            _totalPrice += _BarbatosPrice;
        }
        if (answer += "3")
        {
            _totalPrice += _AstraeaPrice;
        }
        if (answer += "4")
        {
            _totalPrice += _SchwarzritterPrice;
        }
        if (answer += "5")
        {
            _totalPrice += _PhoenixPrice;
        }
    }
   static List<string> _shoppingCart = new List<string>();

   public static void DataMain()
   {
       _shoppingCart.Add("Breaker");
       _shoppingCart.Add("Barbatos");
       _shoppingCart.Add("Astraea");
       _shoppingCart.Add("Schwarzritter");
       _shoppingCart.Add("Phoenix");

       Console.Clear();
       Console.WriteLine("====ModelHaven Demo====");
       bool repeat = true;
       while (repeat)
       {
           Console.WriteLine("What can I do for you?");
           Console.WriteLine("1 - Remove item from the cart");
           Console.WriteLine("2 - Search for item in the cart");
           Console.WriteLine("3 - Exit");

           string answer = Console.ReadLine();

           if (answer == "1")
           {
               Console.WriteLine("===========Shopping Cart===========");
               foreach (string item in _shoppingCart)
               {
                   Console.WriteLine(item);
               }
               Console.WriteLine("============================");
               Console.WriteLine("Please tell me the name of the item you want to remove");

               string item2 = Console.ReadLine();

               if (_shoppingCart.Remove(item2))
               {
                   Console.WriteLine("Item removed successfully!");
               }
               else
               {
                   Console.WriteLine("Failed to remove item, doesn't exist in cart");
               }
               else if (answer == "2")
               {
                   Console.WriteLine("Please tell me the name of the item you want to find");

                   string item3 = Console.ReadLine();

                   bool match = false;
                   foreach (string item in _shoppingCart)
                   {
                       if (item3 == item)
                       {
                           match = true;
                       }
                   }
                   if (match)
                   {
                       Console.WriteLine("Item was found");
                   }
                   else
                   {
                       Console.WriteLine("Item was not found");
                   }
                
               }
               else if (answer == "3")
               {
                   repeat = false;
               }
               else
               {
                   Console.WriteLine("Please enter a valid response");
               }
           }
       }
   }
}