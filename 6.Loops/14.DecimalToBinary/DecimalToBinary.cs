/*Problem 14. Decimal to Binary Number

Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
*/

using System;


class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        long valueDec = long.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Decimal     Binary");
        Console.WriteLine("------------------------------");
        Console.Write("{0,4} ", valueDec);

        if (valueDec == 0)
        {
            Console.WriteLine("{0,10}", "0");
        }

        string valueBin = "";

        while (valueDec > 0)
        {
            long remainder = valueDec % 2;
            valueDec /= 2;
            valueBin = remainder + valueBin;
        }
        Console.WriteLine("{0,10}", valueBin);
    }
}

