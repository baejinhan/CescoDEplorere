using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESCO.IoT.HeartbeatEHListener
{
    public class ControllerEntity : IControllerData
    {
        public int C002 { get; set; } //Power
        public int C003 { get; set; } //FanSpeed
        public int C004 { get; set; } //Timer
        public int C005 { get; set; } //Ionizer
        public int C006 { get; set; } //Scent
        public int C007 { get; set; }
        public int C008 { get; set; }
        public int C009 { get; set; }
        public int C011 { get; set; }
        public int C012 { get; set; }
        public int C013 { get; set; }
        public int C014 { get; set; }
        public int C015 { get; set; }
        public int C016 { get; set; }
        public int C017 { get; set; }
        public int C018 { get; set; }
        public int C019 { get; set; }
        public int C020 { get; set; }
    }
}
