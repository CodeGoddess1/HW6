using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConversion
{
    class Program
    {


        static void Main(string[] args)
        {

            string input = "";
            string selection = "";
            //string Temp = "";
            do
            {
                Console.WriteLine("Would you like the value converted to Celsius(C) or Fahrenheit(F)?");
                input = Console.ReadLine();
                Console.WriteLine("Please Provide Temp");
                string Temp = "";
                Temp = Console.ReadLine();
                

                if (input == "F")
                {
                    double fahrenheit = (double.Parse(Temp) * 9 / 5) + 32;
                    Console.WriteLine($"Fahrenheit temperature:{fahrenheit}F");



                }
                if (input == "C")
                {
                    double celsius = (double.Parse(Temp) - 32) * 5 / 9;
                    Console.WriteLine($"Celsius temperature:{celsius}C");
                    continue;
                 
                }
            }
            while (selection != "E" && selection != "Exit");
               
            
                    Console.WriteLine("Press E to exit");
            
            
        }
       

    }

    
}  
        
    

