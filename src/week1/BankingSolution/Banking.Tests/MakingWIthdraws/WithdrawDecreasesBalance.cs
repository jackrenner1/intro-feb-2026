using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Tests.MakingDeposits;

public class WithdrawlDecreasesBalance
{
    [Fact]
    public void Depositing()
    {
        var account = new Account();

        var openingBalance = account.GetBalance();

        var amountToWithdraw = 123.23M;

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }
}
