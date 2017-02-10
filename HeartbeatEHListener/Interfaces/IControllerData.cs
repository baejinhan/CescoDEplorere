using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESCO.IoT.HeartbeatEHListener
{
    public interface IControllerData
    {
        int C002 { get; set; } //Power
        int C003 { get; set; } //FanSpeed
        int C004 { get; set; } //Timer
        int C005 { get; set; } //Ionizer
        int C006 { get; set; } //Scent
        int C007 { get; set; }
        int C008 { get; set; }
        int C009 { get; set; }
        int C011{ get; set; }
        int C012 { get; set; }
        int C013 { get; set; }
        int C014 { get; set; }
        int C015 { get; set; }
        int C016 { get; set; }
        int C017 { get; set; }
        int C018 { get; set; }
        int C019 { get; set; }
        int C020 { get; set; }
    }
}
