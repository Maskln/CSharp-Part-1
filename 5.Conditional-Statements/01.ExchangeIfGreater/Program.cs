/*Problem 1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values
if the first one is greater than the second one. As a result print the values a and b, separated by a space.
*/

using System;



class ExchangeIfGreater
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        Console.Write("Enter a value for \"a\": ");
        double valueA = double.Parse(Console.ReadLine());

        Console.Write("Enter a value for \"b\": ");
        double valueB = double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("a   b   result");
        Console.WriteLine("--------------");
        Console.Write("{0} {1,3}   ", valueA, valueB);

        if (valueA > valueB)
        {
            double temp = valueA;
            valueA = valueB;
            valueB = temp;
            Console.WriteLine("{0} {1}", valueA, valueB);
        }
        else
        {
            Console.WriteLine("{0} {1}", valueA, valueB);
        }

    }
}
