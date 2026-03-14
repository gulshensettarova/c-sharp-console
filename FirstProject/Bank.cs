using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Bank
    {
        public string Name;
        public List<BankAccount> Accounts = new List<BankAccount>();

        public Bank(string name)
        {
            Name = name;
        }

        public void AddAccount(BankAccount account)
        {
            Accounts.Add(account);
        }

        public void ShowAccounts()
        {
            foreach (var acc in Accounts)
            {
                Console.WriteLine(acc.AccountNumber + " - " + acc.Owner.Name);
            }
        }
    }
}
