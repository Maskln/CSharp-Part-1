/*Problem 13. Check a Bit at Given Position

Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
*/

using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {

        int position;
        int num;
        bool bitAtOne;

        Console.Write("Enter a Value for \"n\": ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a Value for \"position\": ");
        position = Convert.ToInt32(Console.ReadLine());

        int mask = 1 << position;
        int numAndmask = num & mask;
        int bit = numAndmask >> position;

        bitAtOne = (bit == 1) ? true : false;
        

        Console.WriteLine();
        Console.WriteLine("{0} {1} {2} {3}", "n", "Binary Representation", "Position", "Bit @ p == 1");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("{0} {1,5} {2,7} {3,12}", num, Convert.ToString(num, 2).PadLeft(16, '0'), position, bitAtOne);
    }
}
