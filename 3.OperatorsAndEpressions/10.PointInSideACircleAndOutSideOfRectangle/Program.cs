/* Problem 10. Point Inside a Circle & Outside of a Rectangle

Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/

using System;


class PointInSideACircleAndOutSideOfRectangle
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        double valueX;
        double valueY;

        Console.Write("Enter a value for X: ");
        valueX = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter a value for Y: ");
        valueY = Convert.ToDouble(Console.ReadLine());

        double valueRad = 1.5;
        bool inSideCircle = false;
        bool outSideRect = false;
        string result;

       
        if (((1 - valueX) * (1 - valueX) + (1 - valueY) * (1 - valueY)) < (valueRad * valueRad))
        {
            inSideCircle = true;
        }
        if (valueX < -1 || valueX > 5 && valueY < -1 || valueY > 1)
        {
            outSideRect = true;
        }
        Console.WriteLine();
        Console.WriteLine("{0} {1,5} {2,5}", "X", "Y", "Inside K & Outside of R");
        Console.WriteLine("-------------------------------");

        if (inSideCircle && outSideRect)
        {
            Console.WriteLine("{0} {1,5} {2,5}", valueX, valueY, "Yes");
        }
        else
        {
            Console.WriteLine("{0} {1,5} {2,5}", valueX, valueY, "No");
        }
    }
}
