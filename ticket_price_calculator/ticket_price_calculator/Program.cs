using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        // Try to convert input to an integer
        bool isValid = int.TryParse(input, out int age);

        if (!isValid || age < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
        else
        {
            decimal ticketPrice;

            // Apply discount based on age
            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7.00m;
            }
            else
            {
                ticketPrice = 10.00m;
            }

            Console.WriteLine($"Your ticket price is GHC{ticketPrice}");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
