using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESCO.IoT.AirPurifier
{
    public class DeviceMessage : IDeviceMessage
    {
        public string Command { get; set; }
        public ISensorData Sensors { get; set; }
        public IControllerData DeviceData { get; set; }
        public MessageType Type { get; set; }
        public string MachineID { get; set; }
        public string Model { get; set; }

  
    }
}
