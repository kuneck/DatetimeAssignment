using System;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            Console.WriteLine("Current date and time: " + DateTime.Now);

            // Ask the user for a number
            Console.Write("Please enter a number of hours: ");
            string input = Console.ReadLine(); // Read the user's input
            int hours = int.Parse(input); // Convert the input to an integer

            // Calculate the exact time it will be in X hours
            DateTime futureTime = DateTime.Now.AddHours(hours);

            // Print the future time to the console
            Console.WriteLine("In " + hours + " hours, it will be: " + futureTime);

            // Wait for the user to press a key before closing the console
            Console.ReadKey();
        }
    }
}
