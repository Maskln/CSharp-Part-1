/*Problem 15. Hexadecimal to Decimal Number

Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
*/

using System;

class HexadecToDecNumber
{
    static void Main()
    {
        Console.Write("Enter a hexademical value: ");
        string valueHex = Console.ReadLine();
        
        byte resultDec = 0;
        long valueDec = 0;

        Console.WriteLine();
        Console.WriteLine("Hexadecimal     Decimal");
        Console.WriteLine("------------------------------");
        Console.Write("{0,4}    ", valueHex);

        for (int i = 0; i < valueHex.Length; i++)
        {
            switch (valueHex[i])
            {
                case '0': resultDec = 0; break;
                case '1': resultDec = 1; break;
                case '2': resultDec = 2; break;
                case '3': resultDec = 3; break;
                case '4': resultDec = 4; break;
                case '5': resultDec = 5; break;
                case '6': resultDec = 6; break;
                case '7': resultDec = 7; break;
                case '8': resultDec = 8; break;
                case '9': resultDec = 9; break;
                case 'A': resultDec = 10; break;
                case 'B': resultDec = 11; break;
                case 'C': resultDec = 12; break;
                case 'D': resultDec = 13; break;
                case 'E': resultDec = 14; break;
                case 'F': resultDec = 15; break;
                
                default:
                    Console.WriteLine("Invalid input!");
                    return;
            }
            
            valueDec += resultDec * (long)Math.Pow(16, ((valueHex.Length - 1) - i));
        }
        
        Console.WriteLine("{0,12}", valueDec);
    }
}
