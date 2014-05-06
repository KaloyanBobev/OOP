//Define class Worker derived from Human with new property WeekSalary
// and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker.

using System;

    public class Worker : Human
    {
        //fields
        private double weekSalary;
        private double workHoursPerDay;

        //properties
        public double WeekSallary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value >=1)
                {
                    this.weekSalary = value;
                }
                else
                {
                    throw new ArgumentException("The salary is negative");
                }
            }
        }
        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value>=1 && value<=12)
                {
                    this.workHoursPerDay = value; 
                }
                else
                {
                    throw new ArgumentException("The work hours must be between 1 and 12 including!");
                }
            }
        }

        //constructor
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            return this.weekSalary / (this.workHoursPerDay * 5);
        }
    }

