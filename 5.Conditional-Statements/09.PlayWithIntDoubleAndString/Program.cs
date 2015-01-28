/*Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
*/

using System;

    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Console.Write("Please choose a type:\n1 --> int\n2 --> double\n3 --> string\nPlease make your choise: ");
            int programType = int.Parse(Console.ReadLine());

            switch (programType)
            {
                case 1:
                    Console.Write("Please enter an Integer: ");
                    int integer = int.Parse(Console.ReadLine());
                    int sum = integer + 1;
                    Console.WriteLine("Result: {0}", sum);
                    break;

                case 2:
                    Console.Write("Please enter a Double: ");
                    double valueDouble = double.Parse(Console.ReadLine());
                    double sumDouble = valueDouble + 1;
                    Console.WriteLine("Result: {0}", sumDouble);
                    break;

                case 3:
                    Console.Write("Please enter a String: ");
                    string nameString = Console.ReadLine();
                    Console.WriteLine("Result: {0}", nameString +"*");
                    break;



                default:
                    Console.WriteLine("Incorrect Choise!");
                    break;
            }

        }
    }
