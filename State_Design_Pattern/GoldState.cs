using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Design_Pattern
{
    /// <summary>
    /// Concrete State Class.
    /// This class implements a behavior associated with a state of Context.
    /// </summary>
    public class GoldState : State
    {
        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="state"></param>
        public GoldState(State state) : this(state.Balance, state.Account) { }

        public GoldState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }

        private void Initialize()
        {
            //Basic Initialization settings values should come from database.
            interest = 0.05;
            lowerLimit = 1000.0;
            uperLimit = 10000000.0;
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
            StateChangeCheck();
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            balance += interest * balance;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (balance < 0.0)
            {
                account.State = new RedState(this);
            }
            else if (balance < lowerLimit)
            {
                account.State = new SilverState(this);
            }
        }
    }
}
