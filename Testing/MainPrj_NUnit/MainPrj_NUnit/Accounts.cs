using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPrj_NUnit
{
    public class Accounts
    {
        private string AccountNo;
        private float Balance;
        public List<Accounts> beneficiaries;


        public Accounts(string accno)
        {
            this.AccountNo = accno;
            this.Balance = 500;
            beneficiaries = new List<Accounts>();
        }

        public float CheckBalance()
        {
            return Balance;
        }

        public void Deposit(float amt)
        {
            Balance += amt;
        }

        public void Withdraw(float amt)
        {
            if (Balance >= amt)
                Balance -= amt;

            else
                throw new Exception("Mot Enough Funds to withdraw..");
        }
    }
}
