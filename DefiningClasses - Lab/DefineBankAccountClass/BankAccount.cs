namespace DefineBankAccountClass
{
    public class BankAccount
    {
        private string id;
        private double balance;

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            private set { this.balance = value; }
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(double amount)
        {
            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account ID{this.id}, balance {this.balance:F2}";
        }
    }
}
