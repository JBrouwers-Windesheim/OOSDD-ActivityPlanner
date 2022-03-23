using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityPlanner.ConsoleUI
{
    internal class ConsoleHelper
    {
        //TODO: DRY-up there is still some duplicate code here..

        public static string GetUserInput(string description)
        {
            Console.Write($"Please enter your {description}: ");
            string? userInput = Console.ReadLine();
            Console.Clear();
            return userInput;
            //return GetUserInput(description, false);
        }

        public static string GetUserInput(string description, bool required) 
        {
            string userInput = string.Empty;
            do
            {
                //Console.Write($"Please enter your {description}: ");
                //userInput = Console.ReadLine();
                //Console.Clear();
                userInput = GetUserInput(description);

            } while (required && string.IsNullOrWhiteSpace(userInput));

            return userInput;
        }

        public static void Print() 
        {
        
        }
    }
}
