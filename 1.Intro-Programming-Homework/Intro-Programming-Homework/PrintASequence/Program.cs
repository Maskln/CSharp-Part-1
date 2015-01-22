/*Problem 9. Print a Sequence

Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
using System;
*/

using System;

    class PrintASequence
    {
        static void Main()
        {        
            
            for (int i = 0; i < 10; i++)
                {
                    if (i % 2 == 0) Console.Write(i + 2 + ", ");

                    else Console.Write((i + 2)*(-1) + ", ");
                }
                    Console.WriteLine();                
        }
    }