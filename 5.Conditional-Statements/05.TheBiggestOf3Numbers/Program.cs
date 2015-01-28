/*Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.
*/

using System;


    class TheBiggestOf3Numbers
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
            Console.WriteLine("a   b   c    Biggest");
            Console.WriteLine("--------------------");
            Console.Write("{0} {1,3} {2,3} ", valueA, valueB, valueC);

            if (valueA > valueB && valueA > valueC) //There are 2 ways to find the biggest value. This is the first one, the second is in Problem 6!
            {
                Console.WriteLine("{0,6}", valueA);
            }
            else if (valueB > valueA && valueB >valueA)
            {
                Console.WriteLine("{0,6}", valueB);
            }
            else if (valueC > valueA && valueC > valueB)
            {
                Console.WriteLine("{0,6}", valueC);
            }
            else
            {
                Console.WriteLine("The values are equal!");
            }
        }
    }
