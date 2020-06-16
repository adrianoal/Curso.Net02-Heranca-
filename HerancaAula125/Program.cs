using System;
using HerancaAula125.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        public static double Balance { get; private set; }

        static void Main(string[] args)

        {
            List<Account> list = new List<Account>();

            //adicionando elementos na lista:

            list.Add(new SavingAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            // como totalizar o saldo de todas as contas?

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Saldo Total de todas as Contas: " + sum.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            // sacando o mesmo valor de todas as contas:

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }
            Console.WriteLine("Após realizar um saque de R$ 10,00 de cada conta, segue saldo atulaizado");
            Console.WriteLine();

            foreach (Account acc in list)
            {
                Console.WriteLine("Saldo atualizado para a conta " 
                    + acc.Number 
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }



            /*
            Account acc = new Account(1001, "Alex", 0.0); // nao pode instanciar uma classe abstrata, por isso erro.
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0); // Loan --> Op. que faz o emprestimo

            // BusinessAccount acc5 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3; 
                BusinessAccount acc5 = acc3 as BusinessAccount; // Outra forma de fazer o casting (as)
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingAccount acc5 = acc3 as SavingAccount; // Outra forma de fazer o casting (as)
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
            */
        }
    }
}