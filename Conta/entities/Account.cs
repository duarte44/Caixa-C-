using Conta.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            if (balance <= 0)
            {
                throw new DomainException("Check your's balance");
            }

            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double Amount)
        {
            Balance += Amount;
        }

        public void WithDraw(double Amount)
        {
            if (Amount > WithDrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            if (Amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }
            
                Balance -= Amount;            
        }

        public override string ToString()
        {
            return Number + ", Nome: " + Holder + " Balance: " + Balance.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
