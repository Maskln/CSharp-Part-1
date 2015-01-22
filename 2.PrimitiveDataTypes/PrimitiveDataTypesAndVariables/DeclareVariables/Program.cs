/*Problem 1. Declare Variables

Declare five variables choosing for each of them the most appropriate of the types byte, sbyte,
short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
Submit the source code of your Visual Studio project as part of your homework submission.
using System;
*/
using System;

    class DeclareVariables
    {
        static void Main()
        {
            ushort value1 = 52130;
            sbyte value2 = -115;
            uint value3 = 4825932;
            byte value4 = 97;
            short value5 = -10000;

            Console.Write("The Values are: {0}, {1}, {2}, {3}, {4}.", value1, value2, value3, value4, value5);
            Console.WriteLine();
        }
    }
