using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESCO.IoT.AirPurifier
{
    public interface IAirpurifier
    {
        string DeviceID { get; }
        ISensor SensorStatus { get; set; }
        IController DeviceContoller { get; set; }
        void ChangeMode(string Command);
        void PumpStatus(IOutputPlugIn Dashboard, IDeviceMessage MachineMessage);
        void AttachOutput(IOutputPlugIn plugIn);
    }





}
