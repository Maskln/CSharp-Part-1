/*roblem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.
*/

using System;
using System.Numerics;

    class CalculateTheExpression
    {
        static void Main()
        {
            int valueN;
            int valueX;

            decimal factorielN = 1;
            decimal powerOfX = 1;
            decimal sum = 0;

            Console.Write("Enter a value for \"n\": ");
            valueN = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a value for \"x\": ");
            valueX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("n  x  s");
            Console.WriteLine("----------------");
            
            for (int i = 1; i <= valueN; i++)
            {
                factorielN *= i;
                powerOfX*= valueX;
                sum += ( factorielN / powerOfX);
            }
            Console.WriteLine("{0}{1,3}  {2:0.00000}", valueN, valueX, sum + 1);
            //Console.WriteLine(powerOfX);
        }
    }

