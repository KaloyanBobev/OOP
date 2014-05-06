using System;

class Person
{
    //fields
    private string name;
    private int? age;

    //properties
    public string Name
    {
        get { return this.name; }
        set
        {
            if (value.Length > 1)
            {
                this.name = value;
            }
            else
            {
                throw new ArgumentException("Name is too short");
            }
        }
    }

    public int? Age
    {
        get { return this.age; }
        set
        {
            if (value > 0 || value < 99)
            {
                throw new ArgumentException("Invalid age");
            }
        }
    }

    //constructor
    public Person(string name, int? age = null)
    {
        this.name = name;
    }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    //method
    public override string ToString()
    {

        return string.Format("Full name of person:{0} and age:{1}", this.Name,((this.Age.ToString() != "") ? this.Age.ToString() : "Not Specified"));
    }
}

