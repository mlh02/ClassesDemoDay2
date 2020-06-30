using System;

namespace ClassesDemoDay2ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            Console.WriteLine("Please give me your first name");
            customer1.FirstName = Console.ReadLine();

            Console.WriteLine("Please give me your last name");
            customer1.LastName = Console.ReadLine();

            Console.Write($"Hello {customer1.FirstName} {customer1.LastName}");
            Console.WriteLine();

            Console.WriteLine("Please enter your age!");
            customer1.Age = int.Parse(Console.ReadLine());

            if (customer1.Age < 18)
            {
                Console.WriteLine("You're too young to have a bank account!");
            }
            else
            {
                CheckingAccount checkingAccount = new CheckingAccount();
                checkingAccount.RoutingNumber = "654000457";
                checkingAccount.AccountNumber = "2541234";
                checkingAccount.Owner = customer1;
                Console.WriteLine($"Your checking account number is: {checkingAccount.AccountNumber}");
                Console.WriteLine($"The owner of the account is: {checkingAccount.Owner.FirstName} {checkingAccount.Owner.LastName}");
            }
        }
    }
}
