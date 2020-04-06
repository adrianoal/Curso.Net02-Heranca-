using System;
using HerancaAula125.Entities;

namespace HerancaAula125.Entities
{
    class SavingAccount : Account
    {
        public double InterestRate { get; set; } // Taxa de juros

        public SavingAccount()
        {
        }

        public SavingAccount(int number, string holder, double balance, double interestRate) : base (number, holder, balance)
        {
            
            InterestRate = interestRate;
        }
        
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }



    }
}
