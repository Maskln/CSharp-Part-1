/*Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.
 */

using System;

    class Rectangles
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.Write("Enter a width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Enter a height: ");
            double height = double.Parse(Console.ReadLine());

            double perimeter = (width + height) * 2;
            double area = (width * height);
            Console.WriteLine();
            Console.WriteLine("Width Height Perimeter Area");
            Console.WriteLine("---------------------------");
            Console.WriteLine("{0,3} {1,5} {2,8} {3,7}", width, height, perimeter, area);


        }
    }
