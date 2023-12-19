using System;

static class SavingsAccount
{
    private const float NegativeBalanceInterestRate = 3.213f;
    private const float LowBalanceInterestRate = 0.5f;
    private const float MediumBalanceInterestRate = 1.621f;
    private const float HighBalanceInterestRate = 2.475f;

    public static decimal InterestRate(decimal balance)
    {
        if (balance < 0)
        {
            return (decimal)NegativeBalanceInterestRate;
        }
        else if (balance < 1000)
        {
            return (decimal)LowBalanceInterestRate;
        }
        else if (balance < 5000)
        {
            return (decimal)MediumBalanceInterestRate;
        }
        else
        {
            return (decimal)HighBalanceInterestRate;
        }
    }

    public static decimal Interest(decimal balance)
    {
        float interestRate = InterestRate(balance);

        return balance * (decimal)(interestRate / 100);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}
