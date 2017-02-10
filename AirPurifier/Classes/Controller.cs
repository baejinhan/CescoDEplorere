using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESCO.IoT.AirPurifier
{
    class Controller : IController
    {
        private string _machineID;
        private IControllerData _controllerData;
        public Controller(string MachineID)
        {
            _machineID = MachineID;
        }

        public string MachineID
        {
            get
            {
                return _machineID;
            }
        }

        IControllerData IController.ControlPannel
        {
            get
            {
                return _controllerData;
            }

            set
            {
                _controllerData = value;
            }
        }

        public void Start()
        {
            //throw new NotImplementedException();
        }

        public void Stop()
        {
            //throw new NotImplementedException();
        }
    }
}
