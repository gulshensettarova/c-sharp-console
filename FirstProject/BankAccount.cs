using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class BankAccount
    {
        public string AccountNumber;
        public Customer Owner;
        public double Balance;

        public BankAccount(string accountNumber, Customer owner, double balance)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine(amount + " deposited.");
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine(amount + " withdrawn.");
            }
            else
            {
                Console.WriteLine("Not enough balance.");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine("Balance: " + Balance);
        }
    }
}
