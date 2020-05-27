using AccountException.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AccountException.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (WithdrawLimit < amount)
            {
                throw new DomainExceptions("The amount exceeds withdraw limit");
            }
            if (Balance < amount)
            {
                throw new DomainExceptions("Not enought balance");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Number: " + Number);
            sb.AppendLine("Holder: " + Holder);
            sb.AppendLine("Balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("WithDraw Limit: " + WithdrawLimit.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();

        }
    }
}
