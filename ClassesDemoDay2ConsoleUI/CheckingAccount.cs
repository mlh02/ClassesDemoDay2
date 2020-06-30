using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesDemoDay2ConsoleUI
{
    public class CheckingAccount
    {
        //Properties
        public decimal Balance { get; set; }
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
                if(value.Length == 9)
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
    }
}
