/* Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
*/

using System;

class NumberComparer
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        double value1;
        double value2;

        Console.Write("Enter a value for \"a\": ");
        value1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter a value for \"b\": ");
        value2 = Convert.ToDouble(Console.ReadLine());

        double greater = Math.Max(value1, value2);

        Console.WriteLine();
        Console.WriteLine("a   b   greater");
        Console.WriteLine("---------------");
        Console.WriteLine("{0} {1,3} {2,5}", value1, value2, greater);



    }
}

