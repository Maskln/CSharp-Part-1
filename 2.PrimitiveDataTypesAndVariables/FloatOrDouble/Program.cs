/*Problem 2. Float or Double?

Which of the following values can be assigned to a variable of type float and which to a variable 
of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost.
*/

using System;

    class FloatOrDouble
    {
        static void Main()
        {
            double[] value1 = { 34.567839023, 12.345, 8923.1234857, 3456.091 };
            
            for (int i = 0; i < value1.Length; i++)
            {
                int numberOfDigits = (value1[i].ToString().Length);

                if (numberOfDigits < 9)
                    Console.WriteLine("{0} is Float!", value1[i]);
                else
                    Console.WriteLine("{0} is Double!", value1[i]);

            }                   
        }
    }
