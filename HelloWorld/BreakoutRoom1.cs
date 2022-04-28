using System.Collections;
public class StoreMenu
{
    public int _eggPrice;
    public int _milkPrice;
    public int _waterPrice;
    public int _totalPrice;

    List<string> _shoppingCart = new List<string>();
    Dictionary<string, int> _StoreItems = new Dictionary<string, int>();
    public void Menu()
    {
    Console.WriteLine("Welcome to the Store Menu");
    Console.WriteLine("Please select from the Menu");
    Console.WriteLine("1. Eggs");
    Console.WriteLine("2. Milk");
    Console.WriteLine("3. Water");
    Console.WriteLine("4. Checkout");
    }
    public StoreMenu()
    {   
    _eggPrice = 2;
    _milkPrice = 4;
    _waterPrice = 2;
    _totalPrice = 0;
    }
    public void CollectionsMain()
    {
    Console.WriteLine("===Dictionary Demo===");
    _StoreItems.Add("eggs", 2);
    _StoreItems.Add("milk", 4);
    _StoreItems.Add("water", 2);
    
   Console.WriteLine("===Shopping Cart===");
    _shoppingCart.Add("egg");
    _shoppingCart.Add("milk");
    _shoppingCart.Add("water");
   
    
    }
}