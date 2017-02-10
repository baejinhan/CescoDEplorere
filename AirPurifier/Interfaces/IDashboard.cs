using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESCO.IoT.AirPurifier
{
    public interface IOutputPlugIn
    {
        Task Display(IDeviceMessage sensor);
    }
}
