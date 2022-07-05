using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var michaelAccount = new BankAccount();

            Console.WriteLine("How much would you like to deposit");

            var amountToDeposit = double.Parse(Console.ReadLine());

            michaelAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your balance is now {michaelsAccount.GetBalance}");

        }
    }

}
