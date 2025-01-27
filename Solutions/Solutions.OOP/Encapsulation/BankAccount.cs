namespace Solutions.OOP.Encapsulation
{
    internal class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal balance)
        {
            Deposit(balance);
        }

        public void Deposit(decimal amount)
        {
            AmountCheck("deposit",amount); // check if the amount is less than or equal to 0
            this.balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            AmountCheck("withdraw",amount); // check if the balance is less than or equal to 0 and less than the amount
            this.balance -= amount;
        }

        private void AmountCheck(string transaction, decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException($"Insufficient funds for {transaction}");
            }

            if (transaction == "withdraw")
            {
                BalanceCheckForWithdraw(amount);
            }
        }

        private void BalanceCheckForWithdraw(decimal amount)
        {
            if (this.balance < amount)
            {
                throw new InvalidOperationException("Insufficient funds for withdraw");
            }
        }

        public decimal GetBalance()
        {
            return this.balance;
        }
    }
}
