/*Problem 8. Numbers from 1 to n

Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], 
each on a single line.
*/

using System;


class NumbersFrom1ToN
{
    static void Main()
    {
        int number;


        Console.Write("Enter a value for \"n\": ");
        number = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("input   output");
        Console.WriteLine("--------------");
        Console.WriteLine(number);

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("{0,11}", i);
        }


    }
}

