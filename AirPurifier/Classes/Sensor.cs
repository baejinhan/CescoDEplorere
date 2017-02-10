using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CESCO.IoT.AirPurifier
{
    public class Sensor : ISensor
    {
        public Sensor(string MachineID)
        {
            _machineID = MachineID;
        }

        private string _machineID;
        public string MachineID { get { return _machineID; } }

        ISensorData ISensor.Sensor
        {
            get
            {
                SensorMessage message = new SensorMessage()
                {
                    D001 = Util.RandomNumGenerator.GetRandomNumber(-10, 40),
                    D002 = Util.RandomNumGenerator.GetRandomNumber(20, 80),
                    D003 = Util.RandomNumGenerator.GetRandomNumber(20, 80),
                    D004 = Util.RandomNumGenerator.GetRandomNumber(10, 80),
                    D005 = Util.RandomNumGenerator.GetRandomNumber(10, 80),
                    D006 = Util.RandomNumGenerator.GetRandomNumber(10, 80),
                    D007 = Util.RandomNumGenerator.GetRandomNumber(10, 80),
                    D008 = Util.RandomNumGenerator.GetRandomNumber(10, 80),
                    D009 = Util.RandomNumGenerator.GetRandomNumber(10, 80),
                    D010 = Util.RandomNumGenerator.GetRandomNumber(10, 80),
                    D011 = Util.RandomNumGenerator.GetRandomNumber(10, 80),
                    D012 = Util.RandomNumGenerator.GetRandomNumber(10, 80),
                    D013 = Util.RandomNumGenerator.GetRandomNumber(10, 80),
                    D014 = Util.RandomNumGenerator.GetRandomNumber(30, 100)
                };
                return message;
            }
        }

        private Sensor()
        {
        }

        //public event EventHandler<SensorTickedEventArgs> SensorTicked;

        public void Start()
        {
            //_innerTimer.Enabled = true;
            //_innerTimer.Start();
        }

        public void Stop()
        {
            //_innerTimer.Stop();
            //_innerTimer.Enabled = false;
        }
    }

}
