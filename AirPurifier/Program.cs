using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CESCO.IoT.AirPurifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int instanceCount = Properties.Settings.Default.InstanceCount;
            List<IAirpurifier> arrayAirPurifier = new List<IAirpurifier>();

            for (int i = 0; i < instanceCount; i++)
            {
                AirPurifier airPurifier = GenAirPurifier(i);
                arrayAirPurifier.Add(airPurifier);
            }
            Console.ReadLine();
        }

        private static AirPurifier GenAirPurifier(int number)
        {
            var airPurifier = new AirPurifier(string.Format("CESCO{0:D3}", number + 1));
            airPurifier.AttachOutput(new ConsoleDash());
            airPurifier.AttachOutput(new IoTHubDash());
            airPurifier.TurnOn(true);
            return airPurifier;
        }
    }
}


