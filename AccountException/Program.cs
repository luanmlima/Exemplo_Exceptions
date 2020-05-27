using AccountException.Entities;
using AccountException.Entities.Exceptions;
using System;
using System.Globalization;

namespace AccountException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Account data:");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("WithDraw Limit: ");
                double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, withDraw);
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.WithDraw(amount);

                Console.WriteLine();
                Console.WriteLine(account);
            }
            catch (DomainExceptions e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error: " +e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " +e.Message);
            }
        }
    }
}
