using System.Media;

namespace PROG6221PART1ST10247357
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); 
            SoundPlayer welcomeMessage = new SoundPlayer(@"WelcomeAudio.wav");// Load the welcome audio file
            welcomeMessage.Play();// Play the audio
            Console.ReadKey();
        }
    }
}
