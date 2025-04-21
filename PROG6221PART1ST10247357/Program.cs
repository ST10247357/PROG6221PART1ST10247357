using System.Media;

namespace PROG6221PART1ST10247357
{
    internal class Program
    {
        // Public static variables to store user's name and user's replies
        public static string reply = "";
        public static string moreAssistance = "";
        // Boolean variables to control the conversation flow
        public static bool keepAsking = true;
        public static bool validResponse = false;
        static void Main(string[] args)
        {
            // Display the bot's logo
            IntroductionUI.Logo();

            // Play a welcome audio message
            IntroductionUI.AudioWelcomeMessage();
            Thread.Sleep(11000);// Pauses the current thread for 7000 milliseconds (which is equal to 7 seconds).
            Console.WriteLine(""); // Leave a line

            // Display the welcome message
            IntroductionUI.WelcomeMessage();
            Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
            Console.WriteLine(""); // Leave a line

            // Get the user's name
            UserName.Name();
            Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
            Console.WriteLine(""); // Leave a line

            // Display a personalized welcome message from the bot
            Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
            Console.WriteLine($"Assistant: Welcome {UserName.name}!");
            Console.ResetColor();// Changes the colour back to white for the user's input

            // Main loop to keep asking the user for assistance until they choose to exit
            while (keepAsking)
            {
                try
                {
                    Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                    Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                    Console.WriteLine("Assistant: How can I assist you?");
                    Console.ResetColor();// Changes the colour back to white for the user's input
                    Console.Write($"{UserName.name}: ");
                    reply = Console.ReadLine();
                    Console.WriteLine(""); // Leave a line

                    // Check if the user's input is empty
                    if (string.IsNullOrWhiteSpace(reply))
                    {
                        throw new ArgumentException("Your input cannot be empty. Please type something.");
                    }

                    // Check user's reply for specific keywords and provide responses from the dictionary
                    if (reply.Contains("how are you", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine("Assitant: I'm doing well.");
                        Console.ResetColor();// Changes the colour back to white for the user's input


                    }
                    else if (reply.Contains("purpose", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine("Assistant: My purpose is to help you stay informed and safe in the digital world.I provide cybersecurity tips, answer questions about online threats, and guide you on best practices to protect your data and devices.");
                        Console.ResetColor();// Changes the colour back to white for the user's input


                    }
                    else if (reply.Contains("can i ask you", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine("Assistant: You can ask me about anything related to cybersecurity awareness.This includes topics like phishing, password security, social engineering, malware, safe browsing habits, mobile security, and how to protect your personal or organizational data.");
                        Console.ResetColor();// Changes the colour back to white for the user's input
                        Console.WriteLine(""); // Leave a line

                    }
                    else if (reply.Contains("phishing", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Phishing";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                     // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input

                    }
                    else if (reply.Contains("safe browsing", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Safe Browsing";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                     // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input


                    }
                    else if (reply.Contains("password safety", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Password Safety";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                     // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input



                    }
                    else if (reply.Contains("malware", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Malware";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                     // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input



                    }
                    else if (reply.Contains("firewalls", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Firewalls";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                     // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input



                    }
                    else if (reply.Contains("two-factor authentication", StringComparison.OrdinalIgnoreCase) || reply.Contains("2fa", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Two-Factor Authentication";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                     // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input


                    }
                    else if (reply.Contains("social engineering", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Social Engineering";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                     // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input


                    }
                    else if (reply.Contains("software updates", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Software Updates";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                     // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input


                    }
                    else if (reply.Contains("data encryption", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Data Encryption";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                     // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input


                    }
                    else if (reply.Contains("network security", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Network Security";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                     // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input


                    }
                    else
                    {
                        // If the bot doesn't understand the input, provide a list of available topics
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        Console.ForegroundColor = ConsoleColor.Red;// Changes the colour of the error message
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");

                        Console.WriteLine("Assistant: I'm sorry, I didn't understand that. Please try asking about one of the following cybersecurity topics:");
                        Console.WriteLine(""); // Leave a line
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        foreach (var topic in CyberSecurityTopics.Topics.Keys)
                        {
                            Console.WriteLine(topic);
                        }
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine(""); // Leave a line
                        Console.ResetColor();// Changes the colour back to white for the user's input
                        Console.WriteLine(""); // Leave a line
                    }

                    // Ask the user if they need more assistance
                    ContinueOrExit();

                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during user input
                    Console.ForegroundColor = ConsoleColor.Red;// Changes the colour of the error message
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine($"Assistant: {ex.Message}");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine(""); // Leave a line
                    Console.ResetColor();// Changes the colour back to white for the user's input


                }
            }


        }
        public static void ContinueOrExit()
        {
            validResponse = false; // RESET this every time the method runs

            while (!validResponse)
            {
                Thread.Sleep(700);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Assistant: Do you need more assistance? (yes/no)");
                Console.ResetColor();
                Thread.Sleep(700);
                Console.Write($"{UserName.name}: ");
                moreAssistance = Console.ReadLine();
                Console.WriteLine("");

                if (string.IsNullOrWhiteSpace(moreAssistance))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Assistant: Please type 'yes' to continue or 'no' to exit.");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.ResetColor();
                    continue;
                }

                if (moreAssistance.Contains("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Assistant: Thank you! Stay safe online.");
                    Thread.Sleep(1500);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                    Console.ResetColor();
                    keepAsking = false;
                    validResponse = true;
                }
                else if (moreAssistance.Contains("yes", StringComparison.OrdinalIgnoreCase))
                {
                    validResponse = true; // This lets the main loop continue asking
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Assistant: Please enter 'yes' or 'no'.");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.ResetColor();
                }
            }
        }
    }
}
