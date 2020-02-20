using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class account
    {
        // variables
        public int accountNumber;
        public string ownerName;
        public double depM;
        public double monthlyFee = 4;
        public double monthlyInterest = .0025;
        public static double minInitialBalance = 1000;
        public static double minimumMonthDeposit = 50;
        private static double balance;
        // contructor
        public account(string name, double dep1)
        {
            ownerName = name;
            balance = dep1;
            Random acc = new Random();
            int acc2 = acc.Next(90000, 99999);
            accountNumber = acc2;
        }
        // methods
        public void increaseBalance(double inc)
        {
            balance += inc;
        }
        public void decreaseBalance(double with)
        {
            balance -= with;
        }
        public double Balance { get { return balance; } } // public looks like attribute can access loike attribute
    }
}
