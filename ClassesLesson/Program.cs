using ClassesLesson.Models;

namespace ClassesLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Device device=new Device(/*width=*/0.3,0.2,1.2);
            Mobile mobile = new Mobile(2,0.4,0.32,1.2);


            //mobile.AddNumber();

            mobile.AddNumber();
            //mobile.ShowNumbers();


            mobile.ShowNumbers();
            mobile.RemoveNumbers(0);
            Console.WriteLine("--------silindikden sora--------");
            mobile.ShowNumbers();











            //device.OpenDevice();    
            //device.CloseDevice();
            //device.OpenDevice();
            //device.CloseDevice();
            //device.CloseDevice();




        }
    }
}
