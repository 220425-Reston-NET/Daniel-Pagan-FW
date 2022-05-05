
using System.Text.Json;
// <summary>
// Serialization is the process of converting your objects into stream of bytes (00111001). JSON (JavaScript Object Notation), or XML
// We will be using JSON file since it is the most popular format for storing and transfering data to other computers
// <summary>

public class Serialization
{
    private string _filepath = "./Data/Car.json";

    public void SerializationMain()
    {
        Console.WriteLine("===Serialization Demo===");

        //Create a car object we are going to store
        Car carObj = new Car()
        {
            Owner = "Stephen",
            Fuel = 100,
            Brand = "Toyota"
        };

        /*
            we will use a premade class called JsonSerializer that was made for serialization converting C# objects into JSON
            JsonSerializer has a Serialize method that will convert the C# object into a string datatype that follows the JSON format
            JsonSerializerOptions object is used to configure the JsonSerializer to make it more readable
        */
        string jsonstring = JsonSerializer.Serialize(carObj, new JsonSerializerOptions(){WriteIndented = true});
        Console.WriteLine(jsonstring);
    
        /*
            we will use a premade class called File that can be used to read/write files
            WriteAllText method will create a file if no file exists and use the jsonstring to store that information in that file
        */
        // File.WriteAllText(_filepath, jsonstring);
        //Next step is reading that file and storing it in a C# object

        try
        {
        //we need to red the file first to get the information back from the JSON file
        string jsonstring2 = File.ReadAllText(_filepath);
        Console.WriteLine(jsonstring2);

        //Deserialize method will convert the jsonstring back into a car object
        Car carObj2 = JsonSerializer.Deserialize<Car>(jsonstring2);
        Console.WriteLine(carObj2.Owner);
            
        }
        //FileNotFoundException means that the Car.json doesn't exist and it tried reading it
        catch (FileNotFoundException)
        {
            Car carobj3 = new Car();
            string jsonstring3 = JsonSerializer.Serialize(carobj3);

            File.WriteAllText(_filepath, jsonstring3);
            string jsonstring4 = File.ReadAllText(_filepath);
            Console.WriteLine(jsonstring4);
            
        }
        //Your can have more catch blocks perfectly fine
        //Generally the lower catch blocks will be more for generic excemptions
        catch (System.Exception)
        {
            throw new System.Exception("You can specify message");
        }
        //This will always run regardless if an except was caught or not
        finally
        {
            //Used for code clean up
        }
    

    }
}