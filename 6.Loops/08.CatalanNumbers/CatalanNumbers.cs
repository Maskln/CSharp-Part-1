/*Problem 8. Catalan Numbers

In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
*/

using System;
using System.Numerics;


class CatalanNumbers
{
    static void Main()
    {
        int valueN;

        Console.Write("Enter a value for \"n\": ");
        valueN = Convert.ToInt32(Console.ReadLine());

        while (valueN < 0 || valueN > 100)
        {
            Console.Write("Wrong value! Please try again: ");
            valueN = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("n   Catalan(n)");
        Console.WriteLine("--------------");

        BigInteger div1 = 1;
        BigInteger div2 = 1;

        for (int i = (valueN + 2); i <= (2 * valueN); i++)
        {
            div1 *= i;
        }

        for (int i = 1; i <= valueN; i++)
        {
            div2 *= i;
        }

        Console.WriteLine("{0}  {1,3}", valueN, (div1 / div2));
    }
}

