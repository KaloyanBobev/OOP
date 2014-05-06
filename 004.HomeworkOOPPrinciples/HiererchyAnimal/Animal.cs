

using System;

   abstract class Animal
    {
        //fields
        private int age;
        private string name;
        AnimalSex sex;

        //prorerties
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >=0)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("The age of animal is negative");
                }
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value !=string.Empty)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("The name is short");
                }
            }
        }

       //constructor
        public Animal(int age, string name, AnimalSex sex)
        {
            this.age = age;
            this.name = name;
            this.sex = sex;
        }

    }

    
