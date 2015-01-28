/* Problem 3. Check for a Play Card

Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.
*/

using System;

class CheckForAPlayCard
{
    static void Main(string[] args)
    {
        string[] cardSigns = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        Console.Write("Enter a card character: ");
        string valueA = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Character   Valid card sign?");
        Console.WriteLine("----------------------------");
        Console.Write("{0,5}", valueA);

        if (Array.IndexOf(cardSigns, valueA) >= 0)
        {
            Console.WriteLine("{0,15}", "Yes");
        }
        else
        {
            Console.WriteLine("{0,15}", "No");
        }
    }
}
