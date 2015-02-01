/*Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.
 */

using System;


class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int valueN;

        Console.Write("Enter a value for \"n\": ");
        valueN = Convert.ToInt16(Console.ReadLine());

        while (valueN < 1)
        {
            Console.Write("Negative Count of values! Try again: ");
            valueN = Convert.ToInt16(Console.ReadLine());
        }

        int max = int.MinValue;
        int min = int.MaxValue;
        double sum = 0.0;
        double avg;

        for (int i = 1; i <= valueN; i++)
        {
            Console.Write("Enter values for each number: ");
            int numbers = int.Parse(Console.ReadLine());

            sum += numbers;

            if (numbers > max)
            {
                max = numbers;
            }
            if (numbers < min)
            {
                min = numbers;
            }
        }

        avg = sum / valueN;

        Console.WriteLine();
        Console.WriteLine("Min = {0}", min);
        Console.WriteLine("Max = {0}", max);
        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine("Avg = {0:0.00}", avg);
    }
}
