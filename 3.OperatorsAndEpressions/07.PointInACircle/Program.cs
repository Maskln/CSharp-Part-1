/*Problem 7. Point in a Circle

Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
*/

using System;

    class PointInACircle
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            double valueX;
            double valueY;
            byte radius = 2;
                        
            Console.Write("Enter a Value for X: ");
            valueX = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a Value for Y: ");
            valueY = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine("X   Y   INSIDE");
            Console.WriteLine("--------------");


            if ((valueX * valueX) + (valueY * valueY) <= (radius * radius))
            {
                Console.WriteLine("{0}{1,4}   true", valueX, valueY);
            }
            else
            {
                Console.WriteLine("{0}{1,4}   false", valueX, valueY);
            }

        }
    }
