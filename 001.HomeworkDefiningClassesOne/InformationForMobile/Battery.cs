

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Battery  // 1. Define battery class
{
    private string batteryModel;
    private decimal hoursIdle;
    private decimal hoursTalk;
    private BatteryType batteryType;

    // 2. Define several constructors

    public Battery()
    {
        this.batteryModel = "";
        this.hoursIdle = 0;
        this.hoursTalk = 0;
        this.batteryType = BatteryType.Null;
    }

    public Battery(string batteryModel, decimal hoursIdle, decimal hoursTalk)
    {
        this.batteryModel = batteryModel;
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
        this.batteryType = BatteryType.Null;
    }

    // 5. Using of properties

    public string BatteryModel
    {
        get { return batteryModel; }
        set
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("Invalid battery model!!!");
            batteryModel = value;
        }
    }

    public decimal HoursIdle
    {
        get { return hoursIdle; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Wrong idle hours!!!");
            hoursIdle = value;
        }
    }

    public decimal HoursTalk
    {
        get { return hoursTalk; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Wrong hours to talk!!!!");
            hoursTalk = value;
        }
    }

}

public enum BatteryType // 3. Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
{
    LiPol, LiIon, NiMH, NiCd, Null
}

