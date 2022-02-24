using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityPlanner.ConsoleUI
{
    internal class ConsoleHelper
    {

        public static string GetUserInput(string description)
        {
            Console.Write($"Please enter your {description}: ");
            string? userInput = Console.ReadLine();
            Console.Clear();
            return userInput;
        }

        public static string GetUserInput(string description, bool required) 
        {
            string userInput = string.Empty;
            do
            {
                Console.Write($"Please enter your {description}: ");
                userInput = Console.ReadLine();
                Console.Clear();

            } while (required && string.IsNullOrWhiteSpace(userInput));

            return userInput;
        }

    }
}
