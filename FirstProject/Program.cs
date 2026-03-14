using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Customer customer1 = new Customer(1, "Gulshan", "Gulshan@mail.com");

            BankAccount account1 = new BankAccount("ACC1001", customer1, 500);

            account1.Deposit(200);
            account1.Withdraw(100);
            account1.ShowBalance();

            Bank bank = new Bank("ABB");
            bank.AddAccount(account1);
            bank.ShowAccounts();
        }
    }
}
