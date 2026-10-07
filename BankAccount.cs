using System;

public class BankAccount
{
    public string AccountId { get; set; } = "";
    public string OwnerName { get; set; } = "";
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Недостатньо коштів на рахунку " + AccountId);
        }
        else
        {
            balance -= amount;
        }
    }

    public void Transfer(decimal amount, BankAccount toAccount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Недостатньо коштів для переказу з рахунку " + AccountId);
        }
        else
        {
            balance -= amount;
            toAccount.Deposit(amount);
        }
    }
}
