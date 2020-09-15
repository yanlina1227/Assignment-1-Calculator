using System;

namespace Assignment_1_Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's work on math!");
            bool keepLooping = true;
            do
            {
                Console.Write("---selection-----\nEnter 1 to run Addition.\nEnter 2 to run Subtraction.\nEnter 3 to run Division.\nEnter 4 to run Multiplication.");
                string userInput = Console.ReadLine(); 
                switch (userInput)
                {
                Random z = new Random();
                int a = z.Next(8);
                int b = z.Next(6);

                    case " 1 ":
                        Console.WriteLine("result is:" + (a + b));
                        break;
                    case " 2 ":
                        Console.WriteLine("result is:" + (a - b));
                        break;
                    case "3 ":
                        Console.WriteLine("result is:" + (a * b));
                        break;
                    case " 4 ":
                        Console.WriteLine("result is:" + (a / b));
                        break;
                        if (a / b) = 0, 

                }
            }while (keepLooping);
        }
   





    
}
 