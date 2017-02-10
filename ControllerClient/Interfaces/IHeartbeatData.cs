using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESCO.IoT.ControllerClient
{
    public interface IHeartbeatData
    {
        string Device_ID { get; set; }
        DateTime LASTDATARECIEVED { get; set; }
        IControllerData DeviceData { get; set; }
    }
}
