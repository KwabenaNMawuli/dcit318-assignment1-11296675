using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a grade score between 0 and 100: ");
        string input = Console.ReadLine();

        // Try to parse the input to an integer
        bool isValid = int.TryParse(input, out int grade);

        if (!isValid || grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }
        else
        {
            string lttr;

            if (grade >= 90)
                lttr = "A";
            else if (grade >= 80)
                lttr = "B";
            else if (grade >= 70)
                lttr = "C";
            else if (grade >= 60)
                lttr = "D";
            else
                lttr = "F";

            Console.WriteLine($"The letter grade is: {lttr}");
        }

        // Exit console application
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
