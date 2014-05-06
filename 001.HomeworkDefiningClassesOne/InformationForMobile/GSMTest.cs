using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GSMTest
{
    static void Main() //7.Write a class GSMTest to test the GSM class
    {
        GSM[] phones = new GSM[4];
        phones[0] = GSM.IPhone4S;
        phones[1] = new GSM("Galaxy", "Samsung", 1099, "Dragan");
        phones[2] = new GSM("Xperia S", "Sony", 599, "John");
        phones[3] = new GSM(299, "Moni");
        GSMCall callOne = new GSMCall(new DateTime(2013, 09, 30, 20, 23, 00), "359888123456", 16);
        GSMCall callTwo = new GSMCall(new DateTime(2013, 09, 30, 20, 01, 12), "359888919598", 106);
        GSMCall callThree = new GSMCall(new DateTime(2013, 09, 30, 17, 59, 43), "359889252158", 580);
        GSMCall callFour = new GSMCall(new DateTime(2013, 09, 30, 09, 15, 41), "359887707707", 205);

        foreach (var phone in phones)
        {
            Console.WriteLine(phone.ToString());
        }

        //12.Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
       
        phones[0].AddCallHistory(callOne);
        phones[0].AddCallHistory(callTwo);
        phones[0].AddCallHistory(callThree);
        phones[0].AddCallHistory(callFour);

        phones[0].ShowCallInfo(phones[0].callHistory);

        phones[0].ShowCallCost(phones[0].CalcTotalPrice(0.37m));
      
        int index = 0;
        int maxDuration = 0;
        for (int i = 0; i < phones[0].callHistory.Count; i++)
        {
            
            if (maxDuration < phones[0].callHistory[i].CallDuration)
            {
                maxDuration = phones[0].callHistory[i].CallDuration;
                index = i;
            }
        }
        phones[0].DeleteCallHistory(phones[0].callHistory[index]);
      
        phones[0].ShowCallInfo(phones[0].callHistory);
        phones[0].ShowCallCost(phones[0].CalcTotalPrice(0.37m));
        
        phones[0].ClearCallHistory();
        phones[0].ShowCallInfo(phones[0].callHistory);
    }
}

