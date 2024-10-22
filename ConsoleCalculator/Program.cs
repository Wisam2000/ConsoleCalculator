using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculation = true;

            while (continueCalculation)
            {
                Console.WriteLine("Simple Console Calculator");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Choose an operation:\n");
                Console.WriteLine("1 - Addition (+)");
                Console.WriteLine("2 - Subtraction (-)");
                Console.WriteLine("3 - Multiplication (*)");
                Console.WriteLine("4 - Division (/)");
                Console.WriteLine("5 - Exit");
                Console.Write("\nEnter your choice (1-5): ");

                
                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    continueCalculation = false;
                    break;
                }

                
                Console.Write("\nEnter the first number: ");
                double number1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nEnter the second number: ");
                double number2 = Convert.ToDouble(Console.ReadLine());

                
                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"\nResult: {number1} + {number2} = {number1 + number2}");
                        break;
                    case "2":
                        Console.WriteLine($"\nResult: {number1} - {number2} = {number1 - number2}");
                        break;
                    case "3":
                        Console.WriteLine($"\nResult: {number1} * {number2} = {number1 * number2}");
                        break;
                    case "4":
                        if (number2 != 0)
                        {
                            Console.WriteLine($"\nResult: {number1} / {number2} = {number1 / number2}");
                        }
                        else
                        {
                            Console.WriteLine("\nError: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid operation.");
                        break;
                }

                Console.WriteLine("\nWould you like to perform another calculation? (y/n)");
                string response = Console.ReadLine();
                if (response.ToLower() != "y")
                {
                    continueCalculation = false;
                }
                Console.WriteLine();
            }

            Console.WriteLine("Thank you for using the calculator. Goodbye!");
        }
    }
}