


namespace Banking.Domain;

public class Account
{
    private decimal _currentBalance = 5000M;

    public int Balance { get; private set; }

    public void Deposit(decimal amountToDeposit)
    {
        _currentBalance += amountToDeposit;
    }

    public decimal GetBalance()
    {
        return _currentBalance; // Fake. Bs. Slime. 
    }

    public void Withdraw(decimal amountToWithdraw)
    {
       _currentBalance -= amountToWithdraw;
    }
}