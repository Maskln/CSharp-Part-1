/*Problem 13. Binary to Decimal Number

Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
*/

using System;


class BinaryToDecimalNumber
{
    static void Main()
    {

        Console.Write("Enter a binary value: ");
        string valueBin = Console.ReadLine();
        
        long valueDec = 0;

        Console.WriteLine();
        Console.WriteLine("Binary                Decimal");
        Console.WriteLine("------------------------------");
        Console.Write("{0}", valueBin);

        for (int i = 0; i < valueBin.Length; i++)
        {
            valueDec += byte.Parse(valueBin[i].ToString()) * (long)Math.Pow(2, ((valueBin.Length - 1) - i));
        }
        Console.WriteLine("{0,22}", valueDec);
    }
}

