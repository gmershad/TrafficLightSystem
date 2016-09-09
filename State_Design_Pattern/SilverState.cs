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
    public class SilverState : State
    {
        /// <summary>
        /// Overloaded Constructor.
        /// </summary>
        /// <param name="state"></param>
        public SilverState(State state) : this(state.Balance, state.Account) { }

        public SilverState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }

        private void Initialize()
        {
            //Basic Initialization settings values should come from database.
            interest = 0.0;
            lowerLimit = 0.0;
            uperLimit = 1000.0;
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
            if (balance < lowerLimit)
            {
                account.State = new RedState(this);
            }
            else if (balance > uperLimit)
            {
                account.State = new GoldState(this);
            }
        }
    }
}
