using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESCO.IoT.AirPurifier
{
    public class ConsoleDash : IOutputPlugIn
    {
        public Task Display(IDeviceMessage sensor)
        {
            string deserializedObject =
                JsonConvert.SerializeObject(sensor, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });

            Console.WriteLine(deserializedObject);
            return Task.FromResult(true);
        }
    }
}
