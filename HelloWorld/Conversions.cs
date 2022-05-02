namespace Day4
{
    public class Conversions
    {
        //Static keyword will make whatever class member belong to the class itself
        //For us, it means we don't have to create an object out of this class to use it
        public static void ConversionsMain()
        {

            //General coding terms
            //Implicit - just means something is done aotomatically (usually the compiler)
            //Explicit - just means you have to write some syntax to do something or to tell the compiler to do something

            Console.WriteLine("===Conversion Demo===");
            int number =10;
            double numberDecimal = 76.3;
            string word = "Hello";

            //Implicit Conversion
            //The computer/compiler will automatically convert one datatype to another without you needing to specify anything
            //The general rule is if you are going from a datatype to another datatype without losing information, it will be implicit conversion
            Console.WriteLine("=Implicit=");

            //double datatype can set its values using an int datatype
            numberDecimal = number;
            Console.WriteLine(numberDecimal);

            //Explicit Conversion
            Console.WriteLine("=Explicit=");
            numberDecimal = 76.5462;
            
            //A cast is required
            //You have to write suntax to tell the compiler/computer to do the conversion anyway regardless of the potential possibility of losing data
            number = (int)numberDecimal;
            Console.WriteLine(number);

            //More Explicit Conversion
            string numberString = number.ToString();
            Console.WriteLine(numberString);

            //Converting string into numerical values
            string doubleString = "438.1239";
            double double2 = Convert.ToDouble(doubleString);
            Console.WriteLine(double2/2);
        }

    }
    
}