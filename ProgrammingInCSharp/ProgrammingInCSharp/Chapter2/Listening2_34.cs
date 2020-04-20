using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Design interface.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    public interface IAccount
    {
        void PayInFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();
    }

    public class BankAccount : IAccount
    {
        private decimal _balance = 0;

        bool IAccount.WithdrawFunds(decimal amount)
        {
            if (amount > _balance) return false;
            _balance = _balance - amount;
            return true;
        }

        void IAccount.PayInFunds(decimal amount)
        {
            _balance = _balance + amount;
        }

        decimal IAccount.GetBalance()
        {
            return _balance;
        }

    }

    class Listening2_34
    {
        public static void Listening2_34Main()
        {
            IAccount account = new BankAccount();
            Console.WriteLine("Initialize BankAccount balance: {0}", account.GetBalance());

            account.PayInFunds(50);
            Console.WriteLine("Pay to account 50: {0}", account.GetBalance());

            account.WithdrawFunds(30);
            Console.WriteLine("Withdraw from account 30: {0}", account.GetBalance());

            Console.ReadKey();
        }

        

    }
}
