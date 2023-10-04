using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class BankAccount
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            if (amount > 0)
                balance += amount;
            else
                Console.WriteLine("Invalid deposit amount.");
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && balance >= amount)
                balance -= amount;
            else
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
    class Program3 {
        public static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount();
            
            b1.Deposit(1000);
            b1.Withdraw(100);
            Console.WriteLine( b1.GetBalance());

            Console.ReadLine();
        }
    }

}
