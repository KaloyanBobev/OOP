using System;

class Student : Human
{
    //fields
    private int grade;

    //properties
    public int Grade
    {
        get
        {
            return this.grade;
        }
        set
        {
            if (value >0)
            {
                this.grade = value;
            }
            else
            {
                throw new ArgumentException("The grade can't be empty");
            }
        }
    }

    //constructor
    public Student(string firstName, string lastName, int grade): base(firstName,lastName) 
    {
        this.grade = grade;
    }
}

