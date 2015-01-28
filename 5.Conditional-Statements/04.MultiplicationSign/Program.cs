/*Problem 4. Multiplication Sign

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.
*/

using System;


    class MultiplicationSign
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

            double product = (valueA * valueB * valueC);

            Console.WriteLine();
            Console.WriteLine("a   b   c    result");
            Console.WriteLine("--------------------");
            Console.Write("{0} {1,3} {2,3} ", valueA, valueB, valueC);
        
            if (product > 0)
            {
                Console.WriteLine("{0,6}", "+");
            }
            else if (product < 0)
            {
                Console.WriteLine("{0,6}", "-");
            }
            else if (product == 0)
            {
                Console.WriteLine("{0,6}", "0");
            }
        }
    }
