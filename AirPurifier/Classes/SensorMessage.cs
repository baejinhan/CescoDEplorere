using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESCO.IoT.AirPurifier
{
    public class SensorMessage : ISensorData
    {
        /// <summary>
        /// 온도
        /// </summary>
        public int D001 { get; set; }
        /// <summary>
        /// 습도
        /// </summary>
        public int D002 { get; set; }
        /// <summary>
        /// VOC
        /// </summary>
        public int D003 { get; set; }
        /// <summary>
        /// CO2
        /// </summary>
        public int D004 { get; set; }
        /// <summary>
        /// RADON
        /// </summary>
        public int D005 { get; set; }
        /// <summary>
        /// PM 1.0 Count
        /// </summary>
        public int D006 { get; set; }
        /// <summary>
        /// PM 1.0 UG/M3
        /// </summary>
        public int D007 { get; set; }
        /// <summary>
        /// PM2.5 Count
        /// </summary>
        public int D008 { get; set; }
        /// <summary>
        /// PM2.5 UG/M3
        /// </summary>
        public int D009 { get; set; }
        /// <summary>
        /// PM10 Count
        /// </summary>
        public int D010 { get; set; }
        /// <summary>
        /// PM10 UG/M3
        /// </summary>
        public int D011 { get; set; }
        /// <summary>
        /// CO
        /// </summary>
        public int D012 { get; set; }
        /// <summary>
        /// 소음
        /// </summary>
        public int D013 { get; set; }
        public int D014 { get; set; }
        public int D015 { get; set; }
        public int D016 { get; set; }
        public int D017 { get; set; }
        public int D018 { get; set; }
        public int D019 { get; set; }
        public int D020 { get; set; }
        public int D021 { get; set; }
        public int D022 { get; set; }
        public int D023 { get; set; }
        public int D024 { get; set; }
        public int D025 { get; set; }
        public int D026 { get; set; }
    }
}
