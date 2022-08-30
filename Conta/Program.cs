using Conta.Entities.Exceptions;
using Conta.entities;
using System;
using System.Globalization;


namespace Conta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data ");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double limit = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            Console.Write("Withdraw limit: ");
            double withdraw = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture)); 

            Account account = new Account(number, holder, limit, withdraw);

            Console.Write("Enter amount for withdraw: ");
            double value = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            Console.WriteLine();


            try
            {
                account.WithDraw(value);

                

                Console.WriteLine(account);
            }

            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }

        }
    }
}

