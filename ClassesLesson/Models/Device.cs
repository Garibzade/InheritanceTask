using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLesson.Models
{
    internal class Device
    {
        public double Width;
        public double Height;
        public double Weight;
        public bool open =false;


        public Device(double width, double height, double weight)
        {
            Width = width;
            Height = height;
            Weight = weight;
        }
        public Device()
        {
            
        }
        public void OpenDevice()
        {
            if (!open) {
                Console.WriteLine("Device is opening...");
                open = true;
            }
            else 
            { 
                Console.WriteLine("Device already opened"); 
            }
        }

        public void CloseDevice()
        {
            if (open)
            {
                Console.WriteLine("Device is closing...");
                open=false;
                
            }
            else
            {
                Console.WriteLine("Device already closed");
            }
        }
    }
}
