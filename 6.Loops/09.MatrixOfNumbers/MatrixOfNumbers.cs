/*Problem 9. Matrix of Numbers

Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
and prints a matrix like in the examples below. Use two nested loops.
*/

using System;


    class MatrixOfNumbers
    {
        static void Main()
        {
            int ValueN;
            
            Console.Write("Enter a value for \"n\": ");
            ValueN = Convert.ToInt16(Console.ReadLine());

            while (ValueN < 1 || ValueN > 20)
            {
                Console.Write("Wrong Value! Try again: ");
                ValueN = Convert.ToInt16(Console.ReadLine());
            }

            for (int i = 1; i <= ValueN; i++)
            {
                for (int j = i; j < i + ValueN; j++)
                {
                    Console.Write("{0,2}", j);
                    
                }
                Console.WriteLine();
            }

        }
    }
