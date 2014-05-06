/* 1.Define a class that holds information about a mobile phone device: model, manufacturer,
 * price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics
 * (size and number of colors). Define 3 separate classes (class GSM holding instances of the classes Battery and Display). 
 2.Define several constructors for the defined classes that take different sets of arguments (the full information for the 
 * class or part of it). Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class InformationForMobile
    {
        static void Maintwo(string[] args)
        {
            GSM mobilePhone = new GSM();

            Console.WriteLine("Enter phone model: ");
            mobilePhone.Model = Console.ReadLine();
            Console.WriteLine("Enter phone manifaturer: ");
            mobilePhone.Manufacturer = Console.ReadLine();
            Console.WriteLine("Enter phone price:");
            mobilePhone.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter phone owner: ");
            mobilePhone.Owner = Console.ReadLine();
            Console.WriteLine("Enter battery model: ");
            mobilePhone.battery.BatteryModel = Console.ReadLine();
            Console.WriteLine("Enter idle hours: ");
            mobilePhone.battery.HoursIdle = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter talk hours:");
            mobilePhone.battery.HoursTalk = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter size of display: ");
            mobilePhone.display.Size = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of colors on display: ");
            mobilePhone.display.NumberOfColor = Console.ReadLine();
          

        }
    }

*/
