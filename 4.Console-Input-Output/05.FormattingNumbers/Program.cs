/*Problem 5. Formatting Numbers

Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.
*/

using System;


class FormattingNumbers
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int value1;
        double value2;
        double value3;

        Console.Write("Enter a vlaue for \"a\": ");
        value1 = Convert.ToInt32(Console.ReadLine());

        while (value1 < 0 || value1 > 500)
        {
            Console.Write("Wrong Value (0 <= a <= 500)\nTry again: ");
            value1 = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter a vlaue for \"b\": ");
        value2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter a vlaue for \"c\": ");
        value3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("{0,-10:X}|{1}|{2,10}|{3,-10}|", value1, Convert.ToString(value1, 2).PadLeft(10, '0'), Math.Round(value2, 2), Math.Round(value3, 3));







    }
}
