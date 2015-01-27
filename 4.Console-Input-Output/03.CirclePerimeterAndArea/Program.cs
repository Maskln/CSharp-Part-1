/* Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted 
with 2 digits after the decimal point.
*/

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        double radius;
        double pi = Math.PI;

        Console.Write("Enter a vlaue for radius of a circle: ");
        radius = Convert.ToDouble(Console.ReadLine());

        double perimeter = 2 * pi * radius;
        double area = pi * (radius * radius);

        Console.WriteLine();
        Console.WriteLine("r   perimeter  area");
        Console.WriteLine("-------------------");
        Console.WriteLine("{0}   {1}   {2}", radius, Math.Round(perimeter, 2), Math.Round(area, 2));
    }
}
