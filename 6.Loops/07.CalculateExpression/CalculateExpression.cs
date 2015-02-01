/*Problem 7. Calculate N! / (K! * (N-K)!)

In combinatorics, the number of ways to choose k different members out of a group of n different elements
(also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100).
 Try to use only two loops.
*/

using System;
using System.Numerics;

class CalculateExpression
{
    static void Main()
    {

        int valueN;
        int valueK;

        Console.Write("Enter a value for \"n\": ");
        valueN = Convert.ToInt32(Console.ReadLine());

        while (valueN < 1 || valueN > 99)
        {
            Console.Write("Wrong value! Please try again: ");
            valueN = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter a value for \"k\": ");
        valueK = Convert.ToInt32(Console.ReadLine());

        while (valueK < 2 || valueK >= valueN)
        {
            Console.Write("Wrong value! Please try again: ");
            valueK = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("n   k   n! / (k! * (n-k)!)");
        Console.WriteLine("--------------------------");

        BigInteger factorielN = 1;
        BigInteger factorielK = 1;
        BigInteger FactorielDiff = 1;
        int diffNK;

        for (int i = 1; i <= valueN; i++)
        {
            factorielN *= i;

            if (i <= valueK)
            {
                factorielK *= i;
            }
        }

        diffNK = (valueN - valueK);

        for (int i = 1; i <= diffNK; i++)
        {
            FactorielDiff *= i;
        }

        Console.WriteLine("{0} {1,3}   {2}", valueN, valueK, factorielN / (factorielK * FactorielDiff));

    }
}
