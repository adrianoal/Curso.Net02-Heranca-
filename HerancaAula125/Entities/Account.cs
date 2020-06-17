namespace HerancaAula125.Entities
{
    abstract class Account
    {
        public int Number { get; private set; } // private -> Permite ser acessado pela subclasse, mas nao alterar
        public string Holder { get; private set; }
        public double Balance { get; protected set; } // protected:  So pode ser alterado por alguma subclasse

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // Virtual: Isso sign. q este metodo pode ser sobrescrito pela subclasse:
        public virtual void Withdraw(double quantia)// Op. Saque
        {
            Balance -= quantia + 5.0;
        }

        public void Deposit(double quantia) // Op. Deposito
        {

            Balance += quantia;
        }        
    }
}
