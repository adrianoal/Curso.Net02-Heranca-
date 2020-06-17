using System;
using HerancaAula125.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaAula125.Entities
{
    // sealed: Uso sealed na frente da classe, pq nao que que outras classes herdem dela. (Regra de negocio)
    sealed class SavingAccount : Account
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
        //public sealed override void Withdraw(double quantia) // sealed: Sign. q este metodo pode ser selado, pq ele e um metodo sobreposto da superclasse, e por questao de regra de negocio, nao quero q outros metodos sejam sobreposto apartir dele


        public override void Withdraw(double quantia)
        {
            base.Withdraw(quantia); //base: com o uso da palavra base, eu reaproveito o metodo da superclasse, e implemento minha subclasse com o que eu quiser.
            Balance -= 2.0;            
        }
    }
}

/*
Para que serve selar(sealed) uma classe ou um método?

   * Segurança: Dependendo das regras do negócio, às vezes é desejável garantir que uma classe não seja herdada, ou que um
     método não seja sobreposto. (Ex: o Metodo Withdraw da subclasse SavingsAccount).


    * Geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas podem ser uma
      porta de entrada para inconsistências


    * Performance: Atributos de tipo de uma classe selada são analisados de forma mais rápida
      em tempo de execução.


    * Exemplo clássico: string
*/