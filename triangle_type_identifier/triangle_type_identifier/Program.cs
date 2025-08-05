using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");

        // Get input from user
        Console.Write("Side 1: ");
        bool isValid1 = double.TryParse(Console.ReadLine(), out double side1);

        Console.Write("Side 2: ");
        bool isValid2 = double.TryParse(Console.ReadLine(), out double side2);

        Console.Write("Side 3: ");
        bool isValid3 = double.TryParse(Console.ReadLine(), out double side3);

        // Check for valid numeric inputs
        if (!isValid1 || !isValid2 || !isValid3 || side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            Console.WriteLine("Invalid input. Please enter positive numbers for all sides.");
        }
        // Check if the sides can form a triangle using triangle inequality theorem
        else if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
        {
            Console.WriteLine("These sides do not form a valid triangle.");
        }
        else
        {
            // Determine the type of triangle
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
