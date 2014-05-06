using System;

public class LoanAccaunt : Accaunt, IDepositable
{
    public LoanAccaunt(double balance, double interestRate, Customer customer)
        : base(balance, interestRate, customer)
    {
    }

    public void Deposit(double withdramAmount)
    {
        Balance += withdramAmount;
    }

    public override double CalculateMonthlyInterest(int MonthsNumber)
    {
        if (customer is Invidual)
        {
            return base.CalculateMounthlyInterest(MonthsNumber - 3);
        }
        else if (customer is Company)
        {
            return base.CalculateMounthlyInterest(MonthsNumber - 2);
        }
        else
        {
            throw new Exception("Invalid customer");
        }
    }
}

