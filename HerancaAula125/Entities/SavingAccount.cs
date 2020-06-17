using System;
using HerancaAula125.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaAula125.Entities
{
    class SavingAccount : Account
    {
        public double InterestRate { get; set; } // Taxa de juros

        public SavingAccount()
        {
        }

        public SavingAccount(int number, string holder, double balance, double interestRate) 
            : base (number, holder, balance)
        {
            
            InterestRate = interestRate;
        }
        
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        
        // override: Sign. q estou 'sobrepondo' aproveitando o metodo da superclasse, e implementando na subclasse, conforme abaixo:
        public override void Withdraw(double quantia)
        {
            base.Withdraw(quantia); //base: com o uso da palavra base, eu reaproveito o metodo da superclasse, e implemento minha subclasse com o que eu quiser.
            Balance -= 2.0; 
            
        }



    }
}
