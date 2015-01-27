/*Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
*/

using System;

class SumOfNNumbers
{
    static void Main()
    {
        int number;
        double value;
        double sum = 0.0;

        Console.Write("Enter the count of the numbers: ");
        number = Convert.ToInt16(Console.ReadLine());

       
        for (int i = 1; i <= number; i++)
        {
            Console.Write("Enter a value for numbers: ");
            value = Convert.ToDouble(Console.ReadLine());
            sum += value;
        }

        Console.WriteLine("The sum of numbers is: {0}", sum);
    }
}

