using System;
namespace ClassesDemoDay2ConsoleUI
{
    public class SavingAccount
    {
        public string SavingAccountNumber{ get; set; }
        public string SavingRoutingNumber { get; set; }
        public string AccountNumber { get; set; }
        public Customer SavingOwner { get; set; }
        private decimal _savingBalance;
        public decimal SavingBalance
        {
            get { return _savingBalance; }
            set
            {
                Console.WriteLine("Please enter your pin number");
                string pin = Console.ReadLine();
                if (pin == "1234")
                {
                    _savingBalance = value;
                }
                else
                {
                    Console.WriteLine("Invalid user");
                    return;
                }
            }
        }

        public SavingAccount()
        {
        }
        public void PrintSavingBalance()
        {
            Console.WriteLine($"Your current saving balance is: {SavingBalance}");
        }
    }
}
