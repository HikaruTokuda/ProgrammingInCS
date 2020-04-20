using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Constructors and hierarchies.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    public interface IAccount3
    {
        void PayInFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();
    }

    public class BankAccount3 : IAccount3
    {
        protected decimal _balance = 0;

        public virtual bool WithdrawFunds(decimal amount)
        {
            if (amount > _balance) return false;
            _balance = _balance - amount;
            return true;
        }

        void IAccount3.PayInFunds(decimal amount)
        {
            _balance = _balance + amount;
        }

        decimal IAccount3.GetBalance()
        {
            return _balance;
        }

        public BankAccount3(decimal amount)
        {
            _balance = amount;
        }
    }

    public class BabyAccount3 : BankAccount3, IAccount3
    {
        public override bool WithdrawFunds(decimal amount)
        {
            if (amount > 10) return false;
            if (_balance < amount) return false;
            _balance = _balance - amount;
            return true;
        }

        public BabyAccount3(decimal amount) : base(amount)
        {
        }
    }

    class Listening2_38
    {
        public static void Listening2_38Main()
        {
            IAccount3 account3 = new BabyAccount3(100);
            Console.WriteLine(account3.GetBalance());
            Console.ReadKey();
        }
    }
}
