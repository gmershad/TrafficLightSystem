using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Design_Pattern
{
    /// <summary>
    /// Abstract 'State' Class.
    ///It defines an interface/Abstract class for encapsulating 
    ///the behavior associated with a particular state of the Context.
    /// </summary>
   public abstract class State
    {
        protected Account account;
        protected double balance;
        protected double interest;
        protected double lowerLimit;
        protected double uperLimit;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account Account
        {
            get { return account; }
            set { account = value; }
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void PayInterest();


    }
}
