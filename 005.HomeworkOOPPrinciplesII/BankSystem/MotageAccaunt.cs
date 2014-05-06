using System;

       public class MortgageAccount : Accaunt, IDepositable
    {
        public MortgageAccount(double balance, double interestRate, Customer customer)
            : base(balance, interestRate, customer)
        {
        }

        public void Deposit(double depositAmount)
        {
            Balance += depositAmount;
        }

        public override double CalculateMonthlyInterest(int monthNumber)
        {
            if (customer is Company)
            {
                if (monthNumber < 12)
                {
                    return base.CalculateMounthlyInterest(monthNumber) / 2;
                }
                else
                {
                    return base.CalculateMounthlyInterest(12) / 2 + base.CalculateMounthlyInterest(monthNumber - 12);
                }
            }
            else if (customer is Invidual)
            {
                return base.CalculateMounthlyInterest(monthNumber - 6);
            }
            else
            {
                throw new Exception("Invalid customer type!");
            }
        }
    }
