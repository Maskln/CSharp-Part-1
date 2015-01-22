/*Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types
and descriptive names.
*/

using System;

    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Gosho";
            string middleName = "Ivanov";
            string lastName = "Petrov";
            decimal balance = 65.35M;
            string bankName = "Burkan Bank";
            string iban = "BG80 BNBG 9661 1020 3456 78";
            long creditNum1 = 2536985202455599;
            long creditNum2 = 6849865451983000;
            long creditNum3 = 9865468431265463;

            Console.WriteLine("First Name: {0}\nMiddle Name: {1}\nLast Name: {2}\nBalance: {3} $\nBank Name: {4}\nIBAN: {5}\nCredit Card#1: {6}\nCredit Cart#2: {7}\nCredit Cart#3: {8}\n", firstName, middleName, lastName, balance, bankName, iban, creditNum1, creditNum2, creditNum3);
        }
    }