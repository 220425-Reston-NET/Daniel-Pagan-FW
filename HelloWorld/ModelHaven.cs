namespace ModelHaven
{
    public class MainMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("[1] - Select a model");
            Console.WriteLine("[0] - Exit");
        }
        public string Yourchoice()
        {
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                
                Console.WriteLine("What is the name of the model?");
                
                return "AddModel";
            }
            else if (userInput =="0")
            {
                return "Exit";
            }
            else
            {
                Console.WriteLine("Please input a valid response");
                return "MainMenu";
            }
                       
        }
    }

}