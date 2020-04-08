namespace HerancaAula125.Entities
{
    abstract class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; } // protected:  So pode ser alterado por uma subclasse

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double quantia)
        {
            Balance -= quantia + 5.0;
        }

        public void Deposit(double quantia)
        {

            Balance += quantia;
        }        
    }
}
