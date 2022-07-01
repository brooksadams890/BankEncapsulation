using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("How much would you like to depoist?");
            
            var amountToDeposit = double.Parse(Console.ReadLine());

            account.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your balance is now {account.GetBalance()}");
        }
    }
}
