
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Transaction
    {
        public string Type;
        public double Amount;
        public DateTime Date;

        public Transaction(string type, double amount)
        {
            Type = type;
            Amount = amount;
            Date = DateTime.Now;
        }

        public void ShowTransaction()
        {
            Console.WriteLine(Type + " - " + Amount + " - " + Date);
        }
    }
}
