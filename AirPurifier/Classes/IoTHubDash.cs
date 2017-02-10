using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESCO.IoT.AirPurifier
{
    public class IoTHubDash : IOutputPlugIn
    {
        async public Task Display(IDeviceMessage sensor)
        {
            await AzureIoTHub.SendDeviceToCloudMessageAsync(sensor.MachineID, JsonConvert.SerializeObject(sensor, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }));
        }
    }
}
