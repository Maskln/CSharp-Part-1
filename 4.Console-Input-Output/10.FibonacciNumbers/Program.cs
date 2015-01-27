/* Problem 10. Fibonacci Numbers

Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
*/

using System;

class FibonacciNumbers
{
    static void Main()
    {
        int length;

        Console.Write("Enter the count of the numbers: ");
        length = Convert.ToInt16(Console.ReadLine());

        int value1 = 0, value2 = 1, value3 = 0;
        Console.Write("{0} {1}", value1, value2);

        for (int i = 2; i < length; i++)
        {
            value3 = value1 + value2;
            Console.Write(" {0}", value3);
            value1 = value2;
            value2 = value3;
        }
        Console.WriteLine();
    }

}
