/*Problem 5. Third Digit is 7?

Write an expression that checks for given integer if its third digit from right-to-left is 7.
*/

using System;

class TirtdDigitIs7
{
    static void Main()
    {

        Console.Write("Enter a value: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine();
        Console.WriteLine("n     Third Digit 7?");
        Console.WriteLine("-----------------");
        
        if ((n / 100) % 10 == 7)
        {
            Console.WriteLine("{0} {1,10}", n, "true");
        }
        else
        {
            Console.WriteLine("{0} {1,10}", n, "false");
        }
    }
}
