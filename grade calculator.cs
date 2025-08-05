using System;

class GradeCalculator
{
    static void Main()
    {
        Console.Write("Enter your numerical grade (0 - 100): ");
        string input = Console.ReadLine();
        
        // Try to parse the input to a number
        if (double.TryParse(input, out double grade))
        {
            if (grade >= 0 && grade <= 100)
            {
                if (grade >= 90)
                {
                    Console.WriteLine("Your letter grade is: A");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("Your letter grade is: B");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("Your letter grade is: C");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("Your letter grade is: D");
                }
                else
                {
                    Console.WriteLine("Your letter grade is: F");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a grade between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numerical value.");
        }
    }
}
