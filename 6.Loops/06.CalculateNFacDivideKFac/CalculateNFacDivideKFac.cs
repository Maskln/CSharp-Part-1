/*Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
*/

using System;
using System.Numerics;

    class CalculateNFacDivideKFac
    {
        static void Main()
        {
            int valueN;
            int valueK;

            Console.Write("Enter a valuer for \"n\": ");
            valueN = Convert.ToInt32(Console.ReadLine());

            while (valueN < 1 || valueN > 99 )
            {
                Console.Write("Wrong value! Please try again: ");
                valueN = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter a valuer for \"k\": ");
            valueK = Convert.ToInt32(Console.ReadLine());

            while (valueK < 2 || valueK >= valueN)
            {
                Console.Write("Wrong value! Please try again: ");
                valueK = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("n   k  n!/k!");
            Console.WriteLine("--------------");

            BigInteger factorielN = 1;
            BigInteger factorielK = 1;

            for (int i = 1; i <= valueN; i++)
            {
                 factorielN *= i;
            }

            for (int i = 1; i <= valueK; i++)
            {
                factorielK *= i;
            }
            Console.WriteLine("{0} {1,3} {2,3}", valueN, valueK, factorielN / factorielK );
        }
    }
