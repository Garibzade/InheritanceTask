using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLesson.Models
{
    internal class Laptop:Device
    {
        public byte PortCount;
        public Laptop(double width, double height, double weight,byte portcount):base(width, height, weight)
        {
            PortCount = portcount;
        }
    }
}
