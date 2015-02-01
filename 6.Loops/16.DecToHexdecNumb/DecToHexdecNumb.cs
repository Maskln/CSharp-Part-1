/*Problem 16. Decimal to Hexadecimal Number

Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
*/

using System;


class DecToHexdecNumb
{
    static void Main()
    {
        Console.Write("Enter an integer value: ");
        long valueDec = long.Parse(Console.ReadLine());
        
        string valueHex = "";
        char resultHex = new char();
        long remainder = 0;

        if (valueDec == 0)
        {
            Console.WriteLine(valueDec);
            return;
        }

        Console.WriteLine();
        Console.WriteLine("Decimal     Hexadecimal");
        Console.WriteLine("------------------------");
        Console.Write("{0,4}    ", valueDec);

        while (valueDec > 0)
        {

            remainder = valueDec % 16;
            switch (remainder)
            {
                case 0: resultHex = '0'; break;
                case 1: resultHex = '1'; break;
                case 2: resultHex = '2'; break;
                case 3: resultHex = '3'; break;
                case 4: resultHex = '4'; break;
                case 5: resultHex = '5'; break;
                case 6: resultHex = '6'; break;
                case 7: resultHex = '7'; break;
                case 8: resultHex = '8'; break;
                case 9: resultHex = '9'; break;
                case 10: resultHex = 'A'; break;
                case 11: resultHex = 'B'; break;
                case 12: resultHex = 'C'; break;
                case 13: resultHex = 'D'; break;
                case 14: resultHex = 'E'; break;
                case 15: resultHex = 'F'; break;
                
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
            
            valueDec /= 16;
            valueHex = resultHex + valueHex;
        }
        Console.WriteLine("{0,10}", valueHex);
    }
}

