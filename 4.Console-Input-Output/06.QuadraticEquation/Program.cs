/* Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic
equation ax2 + bx + c = 0 and solves it (prints its real roots).
*/

using System;

class QuadraticEquation
{
    static void Main()
    {
        double valueA;
        double valueB;
        double valueC;
        double discriminant;
        double valueX;
        double valueX1;
        double valueX2;

        Console.Write("Enter a vlaue for \"a\": ");
        valueA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter a vlaue for \"b\": ");
        valueB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter a vlaue for \"c\": ");
        valueC = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine(" a   b   c  roots");
        Console.WriteLine("-----------------------");
        Console.Write("{0,3}{1,3}{2,3}  ", valueA, valueB, valueC);

        discriminant = (valueB * valueB) - (4 * valueA * valueC);

        if (discriminant < 0) // D<0; The equation doesn't have real roots!
        {
            Console.WriteLine("No real roots"); ;
        }
        else if (discriminant == 0) // D=0; The equation has a double root: x = -b/2a
        {
            valueX = -(valueB) / (2 * valueA);
            Console.WriteLine(" x1=x2= {0}", valueX);
        }
        else if (discriminant > 0) // D>0; The equation has two real roots: 
        {
            valueX1 = (-(valueB) - (Math.Sqrt(discriminant))) / (2 * valueA);
            valueX2 = (-(valueB) + (Math.Sqrt(discriminant))) / (2 * valueA);
            Console.WriteLine("x1= {0}; x2= {1}", valueX1, valueX2);
        }
    }
}
