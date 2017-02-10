using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESCO.IoT.AirPurifier.Util
{
    public class RandomNumGenerator
    {
        private static readonly Random randomNumGen = new Random();
        private static readonly object syncLock = new object();

        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            {
                return randomNumGen.Next(min, max);
            }
        }
    }
}
