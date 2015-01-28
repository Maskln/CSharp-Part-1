/*Problem 6. The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements
*/

using System;


    class TheBiggestOf5Numbers
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

            Console.Write("Enter a value for \"d\": ");
            double valueD = double.Parse(Console.ReadLine());

            Console.Write("Enter a value for \"e\": ");
            double valueE = double.Parse(Console.ReadLine());

            double theBiggestValue = valueA;


            if (valueB > theBiggestValue)
            {
                theBiggestValue = valueB;
            }
            if (valueC > theBiggestValue)
	        {
                theBiggestValue = valueC;		 
	        }
            if (valueD > theBiggestValue)
            {
                theBiggestValue = valueD;
            }
            if (valueE > theBiggestValue)
            {
                theBiggestValue = valueE;
            }
            

            Console.WriteLine();
            Console.WriteLine("a   b   c   d     e    Biggest");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("{0} {1,3} {2,3} {3,4} {4,4} {5,4} ", valueA, valueB, valueC, valueD, valueE, theBiggestValue);
        }
    }