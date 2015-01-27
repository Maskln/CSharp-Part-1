/*Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
*/

using System;


class PrintCompanyInformation
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        Console.Write("Enter a Company's name: ");
        string nameComp = (Console.ReadLine());

        Console.Write("Enter a Company's address: ");
        string addressComp = (Console.ReadLine());

        Console.Write("Enter a Company's phone number: ");
        string phoneNumComp = (Console.ReadLine());

        Console.Write("Enter a Company's fax number: ");
        string faxNumComp = (Console.ReadLine());

        Console.Write("Enter a Company's web site: ");
        string webSiteComp = (Console.ReadLine());

        Console.Write("Enter a Manager's First name: ");
        string firstNameMan = (Console.ReadLine());

        Console.Write("Enter a Manager's Last name: ");
        string lastNameMan = (Console.ReadLine());

        Console.Write("Enter a Manager's age: ");
        byte age = byte.Parse(Console.ReadLine());

        Console.Write("Enter a Manager's phone number: ");
        string phoneNumMan = (Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine(nameComp);
        Console.WriteLine("Address: {0}", addressComp);
        Console.WriteLine("Tel. {0}", phoneNumComp);
        Console.WriteLine("Fax: {0}", faxNumComp);
        Console.WriteLine("Web Site: {0}", webSiteComp);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstNameMan, lastNameMan, age, phoneNumMan);





    }
}