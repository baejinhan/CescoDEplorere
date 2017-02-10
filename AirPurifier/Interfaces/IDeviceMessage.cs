using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESCO.IoT.AirPurifier
{
    public enum MessageType
    {
        Command,
        Data,
        Error
    }

    public interface IDeviceMessage
    {
        string MachineID { get; set; }
        string Model { get; set; } //보낼필요? .. 내부 데이터(참조)로 빼는 방법 고려 필요
        MessageType Type { get; set; } //
        string Command { get; set; } //C001 ...... E001.....
        ISensorData Sensors { get; set; }
        IControllerData DeviceData { get; set; }
    }

 
}
