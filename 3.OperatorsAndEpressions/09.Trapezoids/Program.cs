/*Problem 9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h.
*/
using System;

    class Trapezoids
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            double sideA;
            double sideB;
            double height;


            Console.Write("Enter a value for a: ");
            sideA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a value for b: ");
            sideB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a value for h: ");
            height = Convert.ToDouble(Console.ReadLine());

            double area = (((sideA + sideB) * height) / 2);
            
            Console.WriteLine();
            Console.WriteLine("a     b     h     area");
            Console.WriteLine("-----------------------");
            Console.WriteLine("{0} {1,5} {2,5} {3,5}", sideA, sideB, height, area);
        }
    }