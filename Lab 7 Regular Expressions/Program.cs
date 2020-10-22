using System;
using System.Text.RegularExpressions;

namespace Lab_7_Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            Regex namePattern = new Regex(@"^([A-Z])[a-zA-Z]{1,29}$");


            Console.WriteLine("Please enter a valid name:");
            string name = Console.ReadLine();

            if (namePattern.IsMatch(name))
            {
                Console.WriteLine("This is a valid name!");
            }

            if (!namePattern.IsMatch(name))
            {
                Console.WriteLine("Sorry, name is not valid!");
            }

            Console.WriteLine("\n");

            Regex emailPattern= new Regex(@"^[a-zA-Z0-9._ -]{5,30}\@[a-zA-Z0-9.-]{5,10}\.[a-zA-Z]{2,3}$");


            Console.WriteLine("Please enter a valid email:");
            string email = Console.ReadLine();

            if (emailPattern.IsMatch(email))
            {
                Console.WriteLine("This is a valid email!");
            }

            if (!emailPattern.IsMatch(email))
            {
                Console.WriteLine("Sorry, email is not valid!");
            }

            Console.WriteLine("\n");

            Regex phoneNumberreg = new Regex(@"^((\d{3}-)|(\(\d{3}\) ))?\d{3}-\d{4}$");

           
            Console.WriteLine("Please enter a valid phone number:");
            string phoneNumber = Console.ReadLine();

            if (phoneNumberreg.IsMatch(phoneNumber))
            {
                Console.WriteLine("This is a valid number");
            }

            if (!phoneNumberreg.IsMatch(phoneNumber))
            {
                Console.WriteLine("Sorry, phone number is not valid!");
            }

            Console.WriteLine("\n");

            Regex datePattern = new Regex(@"^\d{1,2}\/\d{1,2}\/\d{4}$");

            Console.WriteLine("Please enter a valid date:");
            string date = Console.ReadLine();

            if(datePattern.IsMatch(date))
            {
                Console.WriteLine("This is a valid date.");

            }

            if (!datePattern.IsMatch(date))
            {
                Console.WriteLine("Sorry, this is not a valid date!");
            }

            Console.WriteLine("\n");

           
            Console.ReadLine();
        }


    }
    
}
