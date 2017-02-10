using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESCO.IoT.AirPurifier
{
    public interface IController
    {
        void Start();
        void Stop();
        string MachineID { get; }
        IControllerData ControlPannel { get; set; }
    }
}
