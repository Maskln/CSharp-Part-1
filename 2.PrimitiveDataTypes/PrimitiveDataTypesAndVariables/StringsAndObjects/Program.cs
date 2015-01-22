/*Problem 6. Strings and Objects

Declare two string variables and assign them with Hello and World.
Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
*/

using System;

    class StringsAndObjects
    {
        static void Main()
        {
            string value1 = "Hello ";
            string value2 = "World";
            object value3 = value1 + value2;            
            string value4 = (string)value3;
           
            Console.WriteLine(value4);
        }
    }
