using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Create and implement classes based on the IComparable, IEnumerable, IDisposable, and IUnknown interface.
/// The .NET framework provides services that make use of particular behaviors that may be provided by a given
/// object. Each of these behaviors is described by an interface.
/// If you want your objects to be manipulated by .NET in terms of these interfaces you need to make your objects
/// implement the interfaces.

/// <summary>
/// IComparable
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    public interface IAccount4
    {
        void PayInFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();
    }

    public class BankAccount4 : IAccount4, IComparable
    {
        protected decimal _balance = 0;

        public virtual bool WithdrawFunds(decimal amount)
        {
            if (amount > _balance) return false;
            _balance = _balance - amount;
            return true;
        }

        void IAccount4.PayInFunds(decimal amount)
        {
            _balance = _balance + amount;
        }

        decimal IAccount4.GetBalance()
        {
            return _balance;
        }

        public BankAccount4(decimal amount)
        {
            _balance = amount;
        }

        public int CompareTo(object obj)
        {
            // fi we are being compared with a null object we are definitely after it.
            if (obj == null) return -1;

            // convert the object reference into an account reference
            IAccount4 account4 = obj as IAccount4;

            // as generate null if the conversion fails.
            if (account4 == null)
            {
                throw new ArgumentException("Obect is not an account.");
            }

            // use the balance value as the basis of the comparison
            return this._balance.CompareTo(account4.GetBalance());
        }
    }

    class Listening2_39
    {
        public static void Listening2_39Main()
        {
            // Create 20 accounts with random balances.
            List<IAccount4> accounts = new List<IAccount4>();
            Random random = new Random(1);

            for (int i = 0; i < 20; i++)
            {
                IAccount4 account = new BankAccount4(random.Next(0, 10000));
                accounts.Add(account);
            }

            // sort the accounts.
            accounts.Sort();
            

            // Display the sorted accounts
            foreach (IAccount4 account in accounts)
            {
                Console.WriteLine(account.GetBalance());
            }

            Console.ReadKey();
        }
    }
}
