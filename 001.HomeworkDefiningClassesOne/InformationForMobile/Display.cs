using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Display  // 1. Define display class
{
    private decimal size;
    private string numberOfColor;

    // 2. Define several constructors 

    public Display()
    {
        this.size = 0;
        this.numberOfColor = "";
    }

    public decimal Size
    {
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Invalid display size!!!");
            size = value;
        }
    }

    // 5. Using of properties

    public string NumberOfColor
    {
        get { return numberOfColor; }
        set
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("Invalid number of color!!!");
            numberOfColor = value;
        }
    }
}


