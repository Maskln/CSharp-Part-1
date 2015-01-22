/*Problem 8. Isosceles Triangle

Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

*/
using System;

    class IssoscelesTriangle
    {
        static void Main()
        {
            char value1 = '\uc2a9';

            Console.WriteLine("   " + value1);
            Console.WriteLine("  " + value1 + " " + value1);
            Console.WriteLine(" " + value1 + "   " + value1);
            Console.WriteLine("{0} {0} {0} {0}", value1);
        }
    }
