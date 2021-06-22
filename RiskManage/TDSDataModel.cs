using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManage
{
    class TDSDataModel
    {
        private int TradeId;
        private String Date;
        private int CurrentTradeValue;
        private int CounterPartyId;

        public int GetTradeId() { return this.TradeId; }
        public String GetDate() { return this.Date; }
        public int GetCurrentTradeValue() { return this.CurrentTradeValue; }
        public int GetCounterPartyId() { return this.CounterPartyId; }

        public void SetTradeId(int value) { this.TradeId = value; }
        public void SetDate(string value) { this.Date = value; }
        public void SetCurrentTradeValue(int value) { this.CurrentTradeValue = value; }
        public void SetCounterPartyId(int value) { this.CounterPartyId = value; }
    }
}
