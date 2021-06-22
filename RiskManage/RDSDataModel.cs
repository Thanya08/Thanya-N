using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManage
{
    class RDSDataModel
    {
        private int CounterPartyId;
        private String Name;

        public int GetCounterPartyId() { return this.CounterPartyId; }
        public String GetName() { return this.Name; }

        public void SetCounterPartyId(int value) { this.CounterPartyId = value; }
        public void SetName(string value) { this.Name = value; }
    }
}
