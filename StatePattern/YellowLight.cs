using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class YellowLight : ITrafficLight
    {
        public void Change(TrafficLight light)
        {
            light.State = new GreenLight();
        }

        public void ReportState()
        {
            Console.WriteLine("Yellow Light");
        }
    }
}
