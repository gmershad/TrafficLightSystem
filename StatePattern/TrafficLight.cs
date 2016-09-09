using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class TrafficLight
    {
        public ITrafficLight State { get; set; }

        public void Change()
        {
            State.Change(this);
        }

        public void ReportState()
        {
            State.ReportState();
        }
    }
}
