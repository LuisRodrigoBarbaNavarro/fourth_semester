using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class TestAccount
    {
        static void Main(string[] args)
        {
            Account account = new Account(50.0);
            Console.WriteLine("Bienvenido al cajero automático: ");
            Console.WriteLine("Saldo disponible: $" + account.getBalance());
            Console.Read();
            account.deposit(100.0);
            Console.ReadKey();
            account.withdraw(147.0);
            Console.ReadKey();
        }
    }
}