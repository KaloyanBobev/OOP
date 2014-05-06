using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person //Both teachers and students are people.
{

    //field
    private string name;

    //properties
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    //constructor
    public Person(string name)
    {
        if (name != string.Empty)
        {
            this.name = name;
        }
        else
        {
            throw new ArgumentException("The name can't be empty");
        }
    }




}

