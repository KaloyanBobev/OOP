using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GSMCall //8.Create a class Call 
{
    private DateTime callDateTime;
    private string dialedNumber;
    private int callDuration;

    public GSMCall(DateTime callDateTime, string dialedNumber, int callDuration)
    {
        this.callDateTime = callDateTime;
        this.dialedNumber = dialedNumber;
        this.callDuration = callDuration;
    }

    public DateTime CallDateTime
    {
        get { return callDateTime; }
        set { callDateTime = value; }
    }

    public string DialedNumber
    {
        get { return dialedNumber; }
        set 
        {
            if (value.Length != 10)
                throw new ArgumentException("Invalid phone number!!!");
            dialedNumber = value;
        }
    }

    public int CallDuration
    {
        get { return callDuration; }
        set 
        {
            if (value <= 0)
                throw new ArgumentException("Unrealized conversation!!!");
            callDuration = value; }
    }
}

