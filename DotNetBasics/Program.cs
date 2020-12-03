using System;

namespace DotNetBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = "1250";
                byte byteValue = Convert.ToByte(number);
            }
            catch (Exception)
            {
                Console.WriteLine("Number cannot be converted...");
            }
           
                
           

            

            Console.WriteLine("Hello World!");
        }
    }
}
