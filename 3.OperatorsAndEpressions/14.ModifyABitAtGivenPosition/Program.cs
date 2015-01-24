/*Problem 14. Modify a Bit at Given Position

We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold
the value v at the position p from the binary representation of n while preserving all other bits in n.
*/

using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        int position;
        int num;
        int v;

        Console.Write("Enter a Value for \"n\": ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a Value for \"position\": ");
        position = Convert.ToInt32(Console.ReadLine());

        do
        {
            Console.Write("Enter a Value for (0/1) \"v\": ");
            v = Convert.ToInt32(Console.ReadLine());
        } while (v != 1 && v != 0);

        int mask = v << position;
        int numAndmask = num | mask;
        int bit = numAndmask >> position;

        bit = v;

        Console.WriteLine();
        Console.WriteLine("{0} {1} {2} {3} {4}  {5}", "n", "Binary Representation", "Position", "v", "Binnary Result", "Result");
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("{0} {1,5} {2,7} {3,7} {4} {5,2}", num, Convert.ToString(num, 2).PadLeft(16, '0'), position, bit, Convert.ToString(numAndmask, 2).PadLeft(16, '0'), numAndmask);
    }
}

