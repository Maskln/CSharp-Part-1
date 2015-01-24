/*Problem 11. Bitwise: Extract Bit #3

Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
*/

using System;


    class BitwiseExtractBitPosition3
    {
        static void Main()
        {
            int position = 3;
            int num;

            Console.Write("Enter a Value for \"n\": ");
            num = Convert.ToInt32(Console.ReadLine());

            int mask = 1 << position;
            int numAndmask = num & mask;
            int bit = numAndmask >> position;
            
            Console.WriteLine();
            Console.WriteLine("{0} {1} {2}", "n", "Binary Representation", "Bit #3");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("{0} {1,5} {2,7}", num, Convert.ToString(num, 2).PadLeft(16, '0'), bit);
        }
    }
