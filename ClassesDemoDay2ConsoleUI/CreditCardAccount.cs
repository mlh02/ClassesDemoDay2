using System;
namespace ClassesDemoDay2ConsoleUI
{
    public class CreditCardAccount
    {
        public string CreditCardAccountNumber { get; set; }
        public string CreditCardRoutingNumber { get; set; }
        public string CreditCardNumber { get; set; }
        public Customer CreditCardOwner { get; set; }

        private decimal _creditCardBalance;
        public decimal CreditCardBalance
        {
            get { return _creditCardBalance; }
            set
            {
                Console.WriteLine("Please enter your pin number");
                string pin = Console.ReadLine();
                if (pin == "1234")
                {
                    _creditCardBalance = value;
                }
                else
                {
                    Console.WriteLine("Invalid user");
                    return;
                }
            }
        }

        public CreditCardAccount()
        {
        }
        public void PrintCreditCardBalance()
        {
            Console.WriteLine($"Your current CreditCard Balance is: {CreditCardBalance}");
        }
    }
}
