/*Problem 8. Prime Number Check

Write an expression that checks if given positive integer number n (n <= 100) is prime
(i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
*/

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int value;


        Console.Write("Enter a value: ");
        value = Convert.ToInt16(Console.ReadLine());

        while (value < 1 || value > 100)
        {
            Console.Write("Invalid Value!\nTry again: ");
            value = Convert.ToInt16(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("n Prime?");
        Console.WriteLine("--------");

        int maxDiv = (int)Math.Sqrt(value);
        int div = 2;
        bool prime = true;

        while (prime && (div <= maxDiv))
        {
            if (value % div == 0)
            {
                prime = false;
            }
            div++;
        }

        Console.WriteLine("{0} {1}", value, prime);
    }
}