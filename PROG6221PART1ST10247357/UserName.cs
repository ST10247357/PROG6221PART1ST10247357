using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221PART1ST10247357
{
    class UserName
    {
        public static string name;

        public static void Name()
        {


            while (true)
            {
                try
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                    Console.WriteLine("Bot: What is your name?");// Asks the user for their name
                    Console.ResetColor();

                    name = Console.ReadLine();

                    // Check if the entered name is empty
                    if (string.IsNullOrWhiteSpace(name))
                    {

                        throw new ArgumentException("Name cannot be empty. Please enter a valid name.");

                    }

                    break; // Exit loop if input is valid
                }
                catch (Exception ex)
                {
                    // Handle exception for empty name input
                    Console.ForegroundColor = ConsoleColor.Red;// Changes the colour of the error message
                    Console.WriteLine("------------------------------------------------------------------------------------------------------"); 
                    Console.WriteLine($"Bot: {ex.Message}");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------"); 
                    Console.WriteLine(""); // Leave a line
                    Console.ResetColor();
                }
            }


        }//End of UserName() method
    }
}
