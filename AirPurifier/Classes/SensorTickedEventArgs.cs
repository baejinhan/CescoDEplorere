using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESCO.IoT.AirPurifier
{
    public class DeviceTickedEventArgs : EventArgs
    {
        public DeviceTickedEventArgs(IDeviceMessage SensorOjbect)
        {
            _sensorData = SensorOjbect;
        }

        private IDeviceMessage _sensorData;
        public IDeviceMessage SensorData { get { return _sensorData; } }
    }
}
