using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GSM  //1. Define a class that holds information about a mobile phone device
{


    private string model;
    private string manufacturer;
    private decimal price;
    private string owner;

    public Battery battery = new Battery();
    public Display display = new Display();

    // 9.Add a property CallHistory in the GSM class 

    public List<GSMCall> callHistory = new List<GSMCall>();

    //6.Add a static field IPhone4S in the GSM class to hold the information about iPhone 4S.

     public static GSM IPhone4S = new GSM("iPhone 4S","Apple",999,"Dancho");

    // 2.Define several constructors

    public GSM()
    {
        this.model = "";
        this.manufacturer = "";
        this.price = 0;
        this.owner = "";
    }
    public GSM(decimal price, string owner)
    {
        this.model = "C3";
        this.manufacturer = "Nokia";
        this.price = price;
        this.owner = owner;
    }

    public GSM(string manufacturer, decimal price, string owner)
    {
        this.model = "C3";
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
    }

    public GSM(string model, string manufacturer, decimal price, string owner)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
    }

    public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
        this.battery = battery;
        this.display = display;
    }

    public override string ToString() //4. Display information for Phone
    {
        StringBuilder infoForPhone = new StringBuilder();
        infoForPhone.Append("Phone info: ");
        if (Model != "")
        {
            infoForPhone.AppendLine("Phone model" + Model);
        }

        if (Manufacturer != "")
        {
            infoForPhone.AppendLine("Phone manufacturer" + Manufacturer);
        }

        if (Price != 0)
        {
            infoForPhone.AppendLine("Phone price" + Price);
        }

        if (Owner != "")
        {
            infoForPhone.AppendLine("Phone owner" + Owner);
        }

        return infoForPhone.ToString();
    }

    // 5. Using of properties

    public string Model
    {
        get { return model; }
        set
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("Invalid phone name!!!");
            model = value;
        }
    }

    public string Manufacturer
    {
        get { return manufacturer; }
        set
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("Invalid manufacturer name!!!");
            manufacturer = value;
        }
    }

    public decimal Price
    {
        get { return price; }
        set
        {
            if (value < 0)
                throw new ArgumentException("The price should be a positive number!!!");
            price = value;
        }
    }

    public string Owner
    {
        get { return owner; }
        set
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("Invalid owner's name!!!");
            owner = value;
        }
    }

    // 10.Add methods in the GSM class for adding and deleting calls from the calls history

    public void AddCallHistory(GSMCall call)
    {
        this.callHistory.Add(call);
    }

    public void DeleteCallHistory(GSMCall call)
    {
        
        if (callHistory.Count > 0)
        {
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                if (call.CallDateTime == this.callHistory[i].CallDateTime)
                {
                    this.callHistory.RemoveAt(i);
                    i--;
                }
            }
        }
        else
        {
            Console.WriteLine("Call history is empty!!!");
        }
    }

    public void ClearCallHistory() 
    {
        callHistory.Clear();
    }

    // 11.Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.

    public decimal CalcTotalPrice(decimal pricePerMinute)
    {
        decimal callTime = 0;
        for (int i = 0; i < this.callHistory.Count; i++)
        {
            callTime += this.callHistory[i].CallDuration;
        }
        decimal callCost = pricePerMinute * (callTime / 60);
        return callCost;
    }

    public void ShowCallCost(decimal callCost)
    {
        Console.WriteLine("Your bill is: ${0:0.00}", callCost);
    }

    public void ShowCallInfo(List<GSMCall> callHistory)
    {
        for (int i = 0; i < this.callHistory.Count; i++)
        {
            Console.WriteLine("{0} {1} {2} s",this.callHistory[i].CallDateTime ,this.callHistory[i].DialedNumber, this.callHistory[i].CallDuration);
        }
    }
}

