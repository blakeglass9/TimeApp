using System;

namespace DateTimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Print the current date and time to the console.
            DateTime currentDateTime = DateTime.Now;  // Gets the current date and time.
            Console.WriteLine("Current Date and Time: " + currentDateTime);

            // Step 2: Ask the user for a number of hours.
            Console.WriteLine("Enter a number of hours:");
            int hours;  // Declare a variable to store the user input.

            // Step 3: Parse the user input to an integer and check for valid input.
            while (!int.TryParse(Console.ReadLine(), out hours))
            {
                Console.WriteLine("Please enter a valid number.");  // Prompt user if input is invalid.
            }

            // Step 4: Calculate the exact time it will be in X hours.
            DateTime futureDateTime = currentDateTime.AddHours(hours);  // Adds the specified number of hours.

            // Step 5: Print the future date and time to the console.
            Console.WriteLine("In " + hours + " hours, it will be: " + futureDateTime);

            // Step 6: Pause to allow the user to see the result before the console closes.
            Console.ReadLine();  // Waits for user input to close the program.
        }
    }
}
