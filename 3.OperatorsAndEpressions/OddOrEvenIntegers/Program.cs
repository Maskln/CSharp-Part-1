/*Problem 1. Odd or Even Integers

Write an expression that checks if given integer is odd or even.
*/

using System;


    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.Write(" n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();      
           
            Console.WriteLine(" {0}{1, 7}", "n", "ODD?");
            Console.WriteLine("-----------");
        

            if (n % 2 == 0)
            {
                Console.WriteLine(" {0}{1, 7}", n, "false");
            }
            else
            {
                Console.WriteLine(" {0}{1, 7}", n, "true");
            }
           
        }
    }