/*Problem 1. Numbers from 1 to N

Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n,
on a single line, separated by a space.
*/

using System;

class NumbersFrom1ToN
{
    static void Main()
    {

        int counter = 1;

        Console.Write("Enter a value for \"n\": ");
        int valueN = int.Parse(Console.ReadLine());

        Console.WriteLine("n   output");
        Console.WriteLine("----------");
        Console.Write("{0}   ", valueN);

        while (counter <= valueN)
        {
            Console.Write("{0} ", counter);
            counter++;
        }
        Console.WriteLine();

    }
}

