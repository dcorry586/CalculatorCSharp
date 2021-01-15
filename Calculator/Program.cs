/*
 * Program.cs
 * 
 * Version information
 * 
 * Author: Dylan Corry
 * Date: 19/11/2020 
 * Description: This is a simple  console calculator program that can carry out basic mathematical operations on two numbers, using C#.
 * 
 * Copyright notice
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 numbers
            int num1 = 0; int num2 = 0;

            // Display title as the c# console  calculator app
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("-------------------------\n");

            // Ask the user to type the first number
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type int the second number
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an option
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            // Use a switch statement to do the math
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 / num2));
                    break;
            }
            // Wait for the user to respons before closing
            Console.WriteLine("Press any key to close the Calculator console app");
            Console.ReadKey();
        }
    }
}
