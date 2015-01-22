/*Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:
*/

using System;

    class EmployeeData
    {
        static void Main()
        {
            string firstName;
            string lastName;
            byte age;
            char gender;
            long personalIDNum;
            int uniqueEmpNum;

            Console.Write("Enter First Name: ");
            firstName = Convert.ToString(Console.ReadLine());
           
            Console.Write("Enter Last Name: ");
            lastName = Convert.ToString(Console.ReadLine());
            
            Console.Write("Enter Age: ");
            age = Convert.ToByte(Console.ReadLine());

            while (age < 0 || age > 100)
            {
                Console.Write("Enter value between 0-100!\nTry again: ");
                age = Convert.ToByte(Console.ReadLine());

            }

            Console.Write("Enter Gender (m/f): ");
            gender = Convert.ToChar(Console.ReadLine());
            
            while (!gender.Equals('m'))
            {
               if(!gender.Equals('f'))
                {
                    Console.Write("Try again!: ");
                    gender = Convert.ToChar(Console.ReadLine());
                }
               else
               {
                   break;
               }
            }
            
            Console.Write("Enter Personal ID number: ");           
            personalIDNum = Convert.ToInt64(Console.ReadLine());

            while(personalIDNum < 1000000000 || personalIDNum > 9999999999)
            {
                Console.Write("Wrong Personal ID Number!\nTry again: ");
                personalIDNum = Convert.ToInt64(Console.ReadLine());
            }

            Console.Write("Enter Unique Employee Number: ");
            uniqueEmpNum = Convert.ToInt32(Console.ReadLine());

            while (uniqueEmpNum < 27560000 || uniqueEmpNum > 27569999)
            {
                Console.Write("Wrong Employee Number!\nTry Again: ");
                uniqueEmpNum = Convert.ToInt32(Console.ReadLine());
            
            }
                      
            Console.WriteLine("_______________________");

            Console.WriteLine(" First Name: {0}\n Last Name: {1}\n Age: {2}\n Gender: {3} \n Personal ID number: {4}\n Unique employee number: {5}", firstName, lastName, age, gender, personalIDNum, uniqueEmpNum);


        }
    }
