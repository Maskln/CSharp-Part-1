/* Problem 2. Bonus Score

Write a program that applies bonus score to given score in the range [1…9] by the following rules:
If the score is between 1 and 3, the program multiplies it by 10.
If the score is between 4 and 6, the program multiplies it by 100.
If the score is between 7 and 9, the program multiplies it by 1000.
If the score is 0 or more than 9, the program prints “invalid score”.
*/

using System;


class BonusScore
{
    static void Main()
    {

        int bonus;

        Console.Write("Enter a Score: ");
        int score = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Score   Result");
        Console.WriteLine("--------------");
        Console.Write("{0,3}", score);

        if (score > 0 && score < 4)
        {
            bonus = score * 10;
            Console.WriteLine("{0,10}", bonus);
        }
        else if (score > 3 && score < 7)
        {
            bonus = score * 100;
            Console.WriteLine("{0,10}", bonus);
        }
        else if (score > 6 && score < 10)
        {
            bonus = score * 1000;
            Console.WriteLine("{0,10}", bonus);
        }
        else if (score < 0 || score > 9)
        {
            Console.WriteLine("   Invalid Score");
        }
    }
}
