using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesDemoDay2ConsoleUI
{
    public class Customer
    {
        //Properties = Member
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsApproved { get; set; }
        public CheckingAccount UserCheckingAccount { get; set; }

        //Default Ctor = Member
        public Customer()
        {

        }

        //Parameterized Ctor = Member
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Deposit(decimal amount)
        {
            UserCheckingAccount.Balance += amount;
        }
        
        public void Withdraw(decimal amount)
        {
            UserCheckingAccount.Balance -= amount;
        }
    }
}
