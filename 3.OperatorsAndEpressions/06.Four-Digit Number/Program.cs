/*Problem 6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
*/

using System;

    class FourDigitNumber
    {
        static void Main()
        {
            int n;
            int a;
            int b;
            int c;
            int d;
            int sum;

            Console.Write("Enter a Four-Digit Number: ");
            n = Convert.ToInt16(Console.ReadLine());

            while (n < 1000 || n > 9999)
            {
                Console.Write("Invalid Number!\nTry again: ");
                n = Convert.ToInt16(Console.ReadLine());
            }

            a = (n / 1000);
            b = ((n / 100) % 10);
            c = ((n / 10) % 10);
            d = (n % 10);

            sum = (a + b + c + d);

            Console.WriteLine();
            Console.WriteLine("n | Sum of Digits | Reversed | Last Digit in Front | 2-nd & 3-rd Digit Exchanged");
            Console.WriteLine("--------------------------------------------------------------------------------");
            
            Console.Write("{0}", n);
            Console.Write("{0,6}", sum);
            Console.Write("{0,12}{1}{2}{3}", d, c, b, a);
            Console.Write("{0,15}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0,15}{1}{2}{3}", a, c, b, d);
        }
    }
