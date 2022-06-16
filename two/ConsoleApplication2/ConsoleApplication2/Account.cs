using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class Account
    {
        private double balance;

        public Account(double initBalace)
        {
            balance = initBalace;
        }

        public double getBalance()
        {
            return balance;
        }

        public void deposit(double atm)
        {
            balance += atm;
            Console.WriteLine("Se han depositado: $" + atm);
            Console.WriteLine("Nuevo balance: $" + getBalance() + "\n");
        }

        public void withdraw(double atm)
        {
            balance -= atm;
            Console.WriteLine("Se han retirado: $" + atm);
            Console.WriteLine("Nuevo balance: $" + getBalance() + "\n");
        }
    }
}