/*Problem 7. Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
*/

using System;


class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers in a single line, separated by a space: ");
        string[] values = Console.ReadLine().Split(' ');

        double valuesSum = 0;
        for (int i = 0; i < values.Length; i++)
        {
            valuesSum += double.Parse(values[i]);

            if (i == values.Length - 1)
            {
                Console.Write(values[i]);
            }
            else
            {
                Console.Write(values[i] + " + ");
            }
        }
        Console.WriteLine(" = {0}", valuesSum);
    }
}
