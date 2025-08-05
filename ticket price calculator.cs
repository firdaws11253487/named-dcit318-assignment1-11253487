using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        // Try to parse input as an integer
        if (int.TryParse(input, out int age) && age >= 0)
        {
            double price;

            // Determine ticket price based on age
            if (age <= 12 || age >= 65)
            {
                price = 7.0;
            }
            else
            {
                price = 10.0;
            }

            Console.WriteLine($"Your ticket price is: GHC{price}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid non-negative age.");
        }
    }
}


