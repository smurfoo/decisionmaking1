/*  
 Purpose: Write a program that will prompt for a number and display “positive” if it is greater than zero,
“negative” if it is less than zero, and “zero” if it is equal to zero.
Input: number
Output: stringmessage
 Author: Ilyas G
Date: Sept 14 2022
 */




namespace decisionmaking1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int number;
            string message;

            // input a number
            Console.Write("Input a number: ");
            number = int.Parse(Console.ReadLine());

            // determine if it positive negative or equal to zero
          if (number > 0)
            {
                message = "positive";
            }
            else
            {
                if (number < 0)
                {
                    message = "negative";
                }
                else
                {
                    message = "zero";
                }
            }


            // display message
            Console.WriteLine($"The number, {number}, is {message}");

        }
    }
}