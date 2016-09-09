using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();
            trafficLight.State = new RedLight();
            trafficLight.ReportState();
            while (true)
            {
                trafficLight.Change();
                trafficLight.ReportState();
                Console.ReadKey();
            }
        }
    }
}
