/*Problem 8. Square Root

Create a console application that calculates and prints the square root of the number 12345.
Find in Internet “how to calculate square root in C#
*/

using System;

    class SquareRoot
    {
     const int number = 12345;

        static void Main()
        {
            Console.WriteLine("The Square Root of 12345 is {0}", Math.Sqrt(number));
        }
    }