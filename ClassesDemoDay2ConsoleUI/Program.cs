using System;

namespace ClassesDemoDay2ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciating a customer = Creating an variable of the Customer data type
            Customer customer1 = new Customer();

            //Getting user input
            Console.WriteLine("Please give me your first name");
            customer1.FirstName = Console.ReadLine();

            Console.WriteLine("Please give me your last name");
            customer1.LastName = Console.ReadLine();

            //Printing customer info
            Console.Write($"Hello {customer1.FirstName} {customer1.LastName}");
            Console.WriteLine();

            Console.WriteLine("Please enter your age!");
            customer1.Age = int.Parse(Console.ReadLine());

            if (customer1.Age > 18)
            {
                //Instanciating a Checking Account
                CheckingAccount checkingAccount = new CheckingAccount();

                //Setting properties for the Checking Account
                checkingAccount.RoutingNumber = "654000457";
                checkingAccount.AccountNumber = "2541234";

                //***** Setting the Owner property to the instance of the customer we created *****//
                checkingAccount.Owner = customer1;

                //***** Setting the CheckingAccount property on the customer class *****//
                customer1.UserCheckingAccount = checkingAccount;

                //Printing the values of the Account
                Console.WriteLine($"Your checking account number is: {checkingAccount.AccountNumber}");
                Console.WriteLine($"The owner of the account is: {checkingAccount.Owner.FirstName} {checkingAccount.Owner.LastName}");
            }
            else
            {
                Console.WriteLine("You're too young to have a bank account!");
                return;
            }

            //Asking user to deposit or withdraw
            Console.WriteLine("Do you want to deposit or withdraw money?");
            string userResponse = Console.ReadLine();

            decimal amount;
            switch (userResponse)
            {
                case "deposit":
                    //Deposit operations
                    Console.WriteLine("How much?");
                    amount = decimal.Parse(Console.ReadLine());
                    customer1.Deposit(amount);
                    customer1.UserCheckingAccount.PrintBalance();
                    break;
                case "withdraw":
                    //Withdraw operations
                    Console.WriteLine("How much?");
                    amount = decimal.Parse(Console.ReadLine());
                    customer1.Withdraw(amount);
                    customer1.UserCheckingAccount.PrintBalance();
                    break;
            }


            //customer1.UserCheckingAccount.
        }
    }
}
