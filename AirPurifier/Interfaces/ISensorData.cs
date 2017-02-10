using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESCO.IoT.AirPurifier
{
    public interface ISensorData
    {
        int D001 { get; set; } //온도
        int D002 { get; set; } //습도
        int D003 { get; set; } //VOC
        int D004 { get; set; } //CO2
        int D005 { get; set; } //RADON
        int D006 { get; set; } //PM1.0(COUNT)
        int D007 { get; set; } //PM1.0(UG/M3)
        int D008 { get; set; } //PM2.5(COUNT)
        int D009 { get; set; } //PM2.5(UG/M3)
        int D010 { get; set; } //PM10 (COUNT)
        int D011 { get; set; } //PM10 (UG/M3)
        int D012 { get; set; } //CO
        int D013 { get; set; } //소음
        int D014 { get; set; } //통합공기질
        int D015 { get; set; }
        int D016 { get; set; }
        int D017 { get; set; }
        int D018 { get; set; }
        int D019 { get; set; }
        int D020 { get; set; }
        int D021 { get; set; }
        int D022 { get; set; }
        int D023 { get; set; }
        int D024 { get; set; }
        int D025 { get; set; }
        int D026 { get; set; }


    }
}
