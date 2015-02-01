/*Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
*/

using System;


class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Enter a value for \"n\": ");
        int valueN = int.Parse(Console.ReadLine());

        Console.Write("Enter a value for Min Range: ");
        int valueMin = int.Parse(Console.ReadLine());

        Console.Write("Enter a value for Max Range: ");
        int valueMax = int.Parse(Console.ReadLine());

        while (valueMin == valueMax || valueMin > valueMax)
        {
            Console.Write("The Max Range have to be bigger than Min Range! Try again: ");
            valueMax = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("n   min   max   random numbers");
        Console.WriteLine("------------------------------");
        Console.Write("{0}{1,5}{2,6}  ", valueN, valueMin, valueMax);

        Random rnd = new Random();

        for (int i = 1; i <= valueN; i++)
        {
            int randValues = rnd.Next(valueMin, valueMax + 1);
            Console.Write("{0,3} ", randValues);
        }
        Console.WriteLine();
    }
}

