/*Write a Boolean expression that checks for given integer if it can be divided (without remainder)
by 7 and 5 at the same time.
*/

using System;

    class DivideBy7And5
    {
        static void Main()
        {
            Console.Write("Enter a Integer Value: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(" {0}      {1}", "n", "Divided by 7 and 5?");
            Console.WriteLine(" ----------------------------");

            if (n % 7 ==0 && n % 5 == 0 && (n != 0))
            {
                Console.WriteLine(" {0}{1,10}", n, "true");
            }
            else
            {
                Console.WriteLine(" {0}{1,10}", n, "false");
            }
        }
    }
