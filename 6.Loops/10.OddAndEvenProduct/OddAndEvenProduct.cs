/*Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
*/

using System;


class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Enter values with spaces between them: ");
        string stringOfNumbs = Console.ReadLine();
                
        string[] values = stringOfNumbs.Split(' ');

        Console.WriteLine();
        Console.WriteLine("Numbers    Result");
        Console.WriteLine("------------------");
        Console.Write("{0}   ", stringOfNumbs );
        
        int productOdd = 1;
        int productEven = 1;
        
        for (int i = 0; i < values.Length; i++)
        {
            int number;
            bool isNumber = int.TryParse(values[i], out number);
           
            if (isNumber)
            {
                if (i % 2 == 0)
                {
                    productEven *= number;
                }
                else if (i % 2 != 0)
                {
                    productOdd *= number;
                }
            }
        }

        if (productEven == productOdd)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

