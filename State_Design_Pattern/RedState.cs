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
    public class RedState : State
    {
        private double serviceFee;

        public RedState(State state)
        {
            this.balance = state.Balance;
            this.account = state.Account;
            Initialize();

        }

        private void Initialize()
        {
            //Basic Initialization settings values should come from database.
            interest = 0.0;
            lowerLimit = -100.0;
            uperLimit = 0.0;
            serviceFee = 15.00;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            balance = amount - serviceFee;
            Console.WriteLine("No funds available for withdrawal!");
        }

        public override void PayInterest()
        {
            Console.WriteLine("No Interest is paid!");
        }

        private void StateChangeCheck()
        {
            if (balance > uperLimit)
            {
                account.State = new SilverState(this);
            }
        }
    }
}
