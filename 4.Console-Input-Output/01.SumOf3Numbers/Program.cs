/*Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.
*/

using System;


class SumOf3Numbers
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        double valueA;
        double valueB;
        double valueC;


        Console.Write("Enter a vlaue for \"a\": ");
        valueA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter a vlaue for \"b\": ");
        valueB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter a vlaue for \"c\": ");
        valueC = Convert.ToDouble(Console.ReadLine());

        double sum = valueA + valueB + valueC;

        Console.WriteLine();
        Console.WriteLine("a   b   c   sum");
        Console.WriteLine("----------------");
        Console.WriteLine("{0} {1,3} {2,3} {3,3}", valueA, valueB, valueC, sum);
    }
}
