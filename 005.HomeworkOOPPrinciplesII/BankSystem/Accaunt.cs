using System;

    public abstract class Accaunt
    {
        //fields
        private double balance;
        private double monthlyInterestRate;
        protected Customer customer;

        //properties
        public double Balance
        {
            get;
            set
            {
                this.balance = value;
            }
        }

        public double MonthlyInterestRate
        {
            get;
            set
            {
                this.monthlyInterestRate = value;
            }
        }

        //constructor

        public Accaunt(double balance,double interestRate, Customer customer)
        {
            this.Balance = balance;
            this.MonthlyInterestRate = interestRate;
            this.customer = customer;
        }

        //method
        public virtual double CalculateMounthlyInterest(int MonthsNumber)
        {
            return MonthsNumber > 0 ? MonthsNumber * MonthlyInterestRate : 0;
        }
    }

