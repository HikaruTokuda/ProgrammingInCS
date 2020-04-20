using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Inherit from a base class & Overriding methods.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    public interface IAccount2
    {
        void PayInFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();
    }

    public class BankAccount2 : IAccount2
    {
        protected decimal _balance = 0;

        public virtual bool WithdrawFunds(decimal amount)
        {
            if (amount > _balance) return false;
            _balance = _balance - amount;
            return true;
        }

        void IAccount2.PayInFunds(decimal amount)
        {
            _balance = _balance + amount;
        }

        decimal IAccount2.GetBalance()
        {
            return _balance;
        }
    }

    public class BabyAccount : BankAccount2, IAccount2
    {
        public override bool WithdrawFunds(decimal amount)
        {
            if (amount > 10) return false;
            if (_balance < amount) return false;
            _balance = _balance - amount;
            return true;
        }
    }

    class Listening2_35
    {
        public static void Listening2_35Main()
        {
            IAccount2 account2 = new BabyAccount();
            account2.PayInFunds(100);
            Console.WriteLine("Balance: {0}", account2.GetBalance());

            bool withDrawComplete = account2.WithdrawFunds(20);
            Console.WriteLine("Withdraw 20: {0}", withDrawComplete);

            Console.ReadKey();
        }
    }
}
