using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CESCO.IoT.AirPurifier
{
    public class AirPurifier : IAirpurifier
    {
        private AirPurifier() { }
        private string _deviceID = "";
        private ISensor _sensor = null;
        private IController _controller = null;
        private List<IOutputPlugIn> _plugins = null;
        private Timer _innerTimer;

        public async Task<string> ReceiveCloudToDeviceMessageAsync()
        {
            var deviceClient = DeviceClient.CreateFromConnectionString(AzureIoTHub.GetDeviceConnectionString(_deviceID), TransportType.Amqp);

            while (true)
            {
                var receivedMessage = await deviceClient.ReceiveAsync();

                if (receivedMessage != null)
                {
                    var messageData = Encoding.ASCII.GetString(receivedMessage.GetBytes());
                    await deviceClient.CompleteAsync(receivedMessage);
                    processCommand(messageData);
                }

                await Task.Delay(TimeSpan.FromSeconds(1));
            }

        }

        private void processCommand(string messageData)
        {
            Console.WriteLine(messageData);
        }

        private void initializeTimer(int interval)
        {
            _innerTimer = new Timer();
            _innerTimer.Elapsed += updateStatus;
            _innerTimer.Interval = interval;
            _innerTimer.Enabled = true;
            _innerTimer.Stop();
        }

        private void updateStatus(object sender, ElapsedEventArgs e)
        {
            DeviceMessage msg = new DeviceMessage()
            {
                MachineID = this.DeviceID,
                Type = MessageType.Data,
                Sensors = _sensor.Sensor,
                DeviceData = _controller.ControlPannel,
                Model = "ModelType1"
            };

            foreach (var item in _plugins)
            {
                PumpStatus(item, msg);
            }
        }

        public AirPurifier(string deviceID)
        {
            InitializeMachine(deviceID);
        }

        private void InitializeMachine(string deviceID)
        {
            _deviceID = deviceID;
            //sensor settings
            _sensor = new Sensor(deviceID);
            //device controller settings
            _controller = new Controller(deviceID);
            _controller.ControlPannel = new ControllerMessage() {  C002 = 0, C003 = 1, C004 = 0, C005 =  0, C006 = 0 };
            //output settings - console or iot hub
            _plugins = new List<IOutputPlugIn>();
            initializeTimer(5000);

            //_iotHubClient = DeviceClient.CreateFromConnectionString(AzureIoTHub.GetDeviceConnectionString(deviceID), TransportType.Mqtt);
            //ReceiveCloudToDeviceMessageAsync();
            Task.Factory.StartNew(() => ReceiveCloudToDeviceMessageAsync());
        }

        public void TurnOn(bool switchFlag)
        {
            if (switchFlag)
            {
                //_sensor.Start();
                _innerTimer.Start();
                _controller.ControlPannel.C002 = 1;
            }
            else
            {
                //_sensor.Stop();
                _innerTimer.Stop();
                _controller.ControlPannel.C002 = 0;
            }
        }

        public string DeviceID
        {
            get
            {
                return _deviceID;
            }
        }

        public ISensor SensorStatus
        {
            get
            {
                return _sensor;
            }

            set
            {
                _sensor = value;
            }
        }

        public IController DeviceContoller
        {
            get
            {
                return _controller;
            }

            set
            {
                _controller = value;
            }
        }

        public void ChangeMode(string Command)
        {

        }

        public void PumpStatus(IOutputPlugIn Dashboard, IDeviceMessage DeviceMessage)
        {
            Dashboard.Display(DeviceMessage);
        }

        public void AttachOutput(IOutputPlugIn plugIn)
        {
            _plugins.Add(plugIn);
        }
    }
}
