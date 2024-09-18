using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to FizzBuzz Game");
                Console.WriteLine("Please enter a number to play the game: ");
                while (true)
                {                                      
                    var number = CheckIfInt();
                    var fizzBuzz = new FizzBuzz();
                    fizzBuzz.Play(number);
                    Console.WriteLine("\nEnter the next number.\nIf you want to exit the application, type 'q'.");
                }   
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }

        private static int CheckIfInt()
        {
            while(true)
            {
                var input = Console.ReadLine();
                if (input.ToUpper() == "Q")
                {
                    Environment.Exit(0);
                }

                if (!int.TryParse(input, out var number))
                {
                    Console.WriteLine("The value provided is not a number");
                    Console.WriteLine("Enter the number: ");
                    return CheckIfInt();
                }
                return number;
            }

        }
    }
}
