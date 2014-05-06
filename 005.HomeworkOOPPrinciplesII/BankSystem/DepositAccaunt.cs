using System;


    public class DepositAccaunt: Accaunt,IWithdrawable,IDepositable
    {

        public DepositAccaunt(double balance, double interstRate, Customer client)
            : base(balance, interstRate, client)
        { 
        }

        public void Withdraw(double withdrawAmount)
        {
            if (Balance >withdrawAmount)
            {
                this.Balance = withdrawAmount;
                Console.WriteLine("balance is{0},after withdraw {1}",Balance,withdrawAmount);
            }
            else
            {
                Console.WriteLine("The bank balance is null");
            }
        }

        public void Deposit(double depositAmount)
        {
            Balance += depositAmount;
        }

        public override double CalculateMounthlyInterest(int MonthsNumber)
        {
            if (Balance > 1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateMounthlyInterest(MonthsNumber);

            }
        }

    }

