/*Problem 12. Extract Bit from Integer

Write an expression that extracts from given integer n the value of given bit at index p.
*/
 using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {
            int position;
            int num;

            Console.Write("Enter a Value for \"n\": ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a Value for \"position\": ");
            position = Convert.ToInt32(Console.ReadLine());

            int mask = 1 << position;
            int numAndmask = num & mask;
            int bit = numAndmask >> position;

            Console.WriteLine();
            Console.WriteLine("{0} {1} {2} {3}", "n", "Binary Representation", "Position", "Bit @ position");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("{0} {1,5} {2,7} {3,8}", num, Convert.ToString(num, 2).PadLeft(16, '0'), position, bit);
        }
    }
