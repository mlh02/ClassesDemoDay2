using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesDemoDay2ConsoleUI
{
    public class CheckingAccount
    {
        //Properties
        private decimal _balance;

        public decimal Balance
        {
            get { return _balance; }

            set
            {
                Console.WriteLine("Please enter your pin number");
                string pin = Console.ReadLine();
                if (pin == "1234")
                {
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("Invalid user");
                    return;
                }
            }
        }

        public string AccountNumber { get; set; }

        //Field = local class variable
        private string _routingNumber;
        public string RoutingNumber
        {
            get
            {
                return _routingNumber;
            }
            set
            {
                if (value.Length == 9)
                {
                    _routingNumber = value;
                }
                else
                {
                    Console.WriteLine("Invalid Routing Number");
                }
            }
        }

        public Customer Owner { get; set; }

        public void PrintBalance()
        {
            Console.WriteLine($"Your current balance is: {Balance}");
        }
    }
}
