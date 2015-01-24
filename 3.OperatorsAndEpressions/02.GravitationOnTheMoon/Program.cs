/* Problem 2. Gravitation on the Moon

The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
*/

using System;

    class GravitationOnTheMoon
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.Write("Enter a weight in kg: ");
            
            double weight = double.Parse(Console.ReadLine());

            double moonWeight = (weight * 0.17);
            
            Console.WriteLine();
            Console.WriteLine(" {0} {1}", "Weight", "Weight on the Moon");
            Console.WriteLine(" -------------------------");
            Console.WriteLine(" {0}{1,10}kg", weight, moonWeight);

        }
    }
