﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahajanBankAccount
{
    class Checking : AbsAccount
    {
        public double chAccountBalance;
        
        //prop
        public double ChAccountBalance
        {get { return this.chAccountBalance; }
         set { this.chAccountBalance = value; }
        }

        //const
        public Checking()
        {
        }

        public Checking(int accountNumber, string accountType, double accountBalance, double chAccountBalance)
        {
            this.accountBalance = accountBalance;
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            this.chAccountBalance = chAccountBalance;
        }

        public override void GetAccountInfo()
        {
            base.GetAccountInfo();
            Console.WriteLine("Your checking account balance is: $" +chAccountBalance);
        }

        public string DepositOrWith()
        {
            return "Would you like to: \n1.Deposit Funds \n2.Withdraw Funds";
        }

        public double CheckDepositAmount()
        {
            chAccountBalance += deposit;
            return chAccountBalance;
        }

        public override string DepositMoney()
        {
            return "How much would you like to deposit?";
        }

        public override string WithMoney()
        {
            return "How much would you like to withdraw?";
        }







    }
}
