/*Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
*/

using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            int? nullInt;
            double? nullDouble;

            nullInt = null;
            nullDouble = null;
            Console.WriteLine("Integer 'Null' Value = '{0}'\nDouble 'Null' Value = '{1}'", nullInt, nullDouble);
            Console.WriteLine();
            Console.WriteLine("Integer 'Null' Value + 123 = '{0}'\nDouble 'Null' Value + 11.3 = '{1}'", nullInt + 123, nullDouble + 11.3);
            Console.WriteLine();         
                
        }
    }

