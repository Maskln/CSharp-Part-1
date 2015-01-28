/*Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.
*/

using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        Console.Write("Enter a value for \"a\": ");
        double valueA = double.Parse(Console.ReadLine());

        Console.Write("Enter a value for \"b\": ");
        double valueB = double.Parse(Console.ReadLine());

        Console.Write("Enter a value for \"c\": ");
        double valueC = double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("a   b   c    Result");
        Console.WriteLine("--------------------");
        Console.Write("{0} {1,3} {2,3}    ", valueA, valueB, valueC);

        if (valueA >= valueB && valueA >= valueC)
        {
            if (valueB >= valueC)
            {
                Console.WriteLine("{0} {1} {2}", valueA, valueB, valueC);

            }
            else
            {
                Console.WriteLine("{0} {1} {2}", valueA, valueC, valueB);
            }
        }
        else if (valueB >= valueA && valueB >= valueC)
        {
            if (valueA >= valueC)
            {
                Console.WriteLine("{0} {1} {2}", valueB, valueA, valueC);

            }
            else
            {
                Console.WriteLine("{0} {1} {2}", valueB, valueC, valueA);
            }
        }
        else if (valueC >= valueA && valueC >= valueB)
        {
            if (valueA >= valueB)
            {
                Console.WriteLine("{0} {1} {2}", valueC, valueA, valueB);

            }
            else
            {
                Console.WriteLine("{0} {1} {2}", valueC, valueB, valueA);
            }
        }
    
    
    
    }
}

