using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManage
{
    class Program
    {
        static void Main(string[] args)
        {
            TDSDataModel Tdsobj = new TDSDataModel();
            RDSDataModel Rdsobj = new RDSDataModel();

            Tdsobj.SetTradeId(1231);
            Tdsobj.SetDate("20210104");
            Tdsobj.SetCurrentTradeValue(214354);
            Tdsobj.SetCounterPartyId(34154231);


            int TradeIdValue=Tdsobj.GetTradeId();
            String DateValue=Tdsobj.GetDate();
            int CurrentTradeValue1=Tdsobj.GetCurrentTradeValue();
            int CounterPartyIdValue=Tdsobj.GetCounterPartyId();



        Rdsobj.SetCounterPartyId(224144354);
            Rdsobj.SetName("thanya");
            int CounterPartyIdValue1 = Rdsobj.GetCounterPartyId();
            String NameValue = Rdsobj.GetName();

    }
}
}
