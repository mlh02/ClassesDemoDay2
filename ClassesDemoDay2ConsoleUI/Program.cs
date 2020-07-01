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
                Console.WriteLine("Please choose \n" +
                    "1 - Checking account \n" +
                    "2 - Saving Account \n" +
                    "3 - Credit Card");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
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

                        //Asking user to deposit or withdraw 
                        Console.WriteLine("Do you want to \n" +   
                            "1 - deposit \n" +
                            "2 - withdraw \n");
                        int userResponse = int.Parse(Console.ReadLine());

                        decimal amount;
                        switch (userResponse)
                        {
                            case 1:
                                //Deposit operations
                                Console.WriteLine("How much?");
                                amount = decimal.Parse(Console.ReadLine());
                                customer1.Deposit(amount);
                                customer1.UserCheckingAccount.PrintBalance();
                                break;
                            case 2:
                                //Withdraw operations
                                Console.WriteLine("How much?");
                                amount = decimal.Parse(Console.ReadLine());
                                customer1.Withdraw(amount);
                                customer1.UserCheckingAccount.PrintBalance();
                                break;
                            case 3:
                                //Withdraw operations
                                Console.WriteLine("How much?");
                                amount = decimal.Parse(Console.ReadLine());
                                customer1.Withdraw(amount);
                                customer1.UserCreditCardAccount.PrintCreditCardBalance();
                                break;
                        }

                        break;
                    case 2:
                        //Instanciating a saving Account
                        SavingAccount savingAccount  = new SavingAccount();

                        //Setting properties for the Saving Account
                        savingAccount.SavingRoutingNumber = "654000423";
                        savingAccount.SavingAccountNumber = "2541224";

                        //***** Setting the Owner property to the instance of the customer we created *****//
                        savingAccount.SavingOwner = customer1;

                        //***** Setting the SavingAccount property on the customer class *****//
                        customer1.UserSavingAccount = savingAccount;

                        //Printing the values of the Saving Account
                        Console.WriteLine($"Your saving account number is: {savingAccount.SavingAccountNumber}");
                        Console.WriteLine($"The owner of the account is: {savingAccount.SavingOwner.FirstName} {savingAccount.SavingOwner.LastName}");

                        //Asking user to deposit or withdraw
                        Console.WriteLine("Do you want to \n" +
                            "1 - deposit \n" +
                            "2 - withdraw");
                        int userResponse2 = int.Parse(Console.ReadLine());

                        decimal amount2;
                        switch (userResponse2)
                        {
                            case 1:
                                //Saving Deposit operations
                                Console.WriteLine("How much?");
                                amount2 = decimal.Parse(Console.ReadLine());
                                customer1.SavingDeposit(amount2);
                                customer1.UserSavingAccount.PrintSavingBalance();
                                break;
                            case 2:
                                //Saving Withdraw operations
                                Console.WriteLine("How much?");
                                amount2 = decimal.Parse(Console.ReadLine());
                                customer1.SavingWithdraw(amount2);
                                customer1.UserSavingAccount.PrintSavingBalance();
                                break;
                                break;
                        }
                        break;
                    case 3:
                        //Instanciating a saving Account
                        CreditCardAccount creditCardAccount = new CreditCardAccount();

                        //Setting properties for the Saving Account
                        creditCardAccount.CreditCardAccountNumber = "654000423";
                        creditCardAccount.CreditCardAccountNumber = "2541224";

                        //***** Setting the Owner property to the instance of the customer we created *****//
                        creditCardAccount.CreditCardOwner = customer1;

                        //***** Setting the SavingAccount property on the customer class *****//
                        customer1.UserCreditCardAccount = creditCardAccount;

                        //Printing the values of the Saving Account
                        Console.WriteLine($"Your saving account number is: {creditCardAccount.CreditCardAccountNumber}");
                        Console.WriteLine($"The owner of the account is: {creditCardAccount.CreditCardOwner.FirstName} {creditCardAccount.CreditCardOwner.LastName}");

                        //Asking user to deposit or withdraw
                        Console.WriteLine("Do you want to \n" +
                            "1 - deposit \n" +
                            "2 - withdraw\n");
                        int userResponse3 = int.Parse(Console.ReadLine());

                        decimal amount3;
                        switch (userResponse3)
                        {
                            case 1:
                                //Saving Deposit operations
                                Console.WriteLine("How much?");
                                amount3 = decimal.Parse(Console.ReadLine());
                                customer1.CreditCardDeposit(amount3);
                                customer1.UserCreditCardAccount.PrintCreditCardBalance();
                                break;
                            case 2:
                                //Saving Withdraw operations
                                Console.WriteLine("How much?");
                                amount3 = decimal.Parse(Console.ReadLine());
                                customer1.CreditCardWithdraw(amount3);
                                customer1.UserCreditCardAccount.PrintCreditCardBalance();
                                break;
                        }

                        break;
                }
            }

            else
            {
                Console.WriteLine("You're too young to have a bank account!");
                return;
            }

        }
    }
}
