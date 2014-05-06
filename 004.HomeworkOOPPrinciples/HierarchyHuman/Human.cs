using System;

    public abstract class Human
    {
        //fields
        private string firstName;
        private string lastName;

        //properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value !=string.Empty)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("The first name can't be empty");
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException("The last name can't be empty");
                }
            }
        }

        //constructors
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }


    }

