using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLesson.Models
{
    internal class Mobile : Device
    {
        public string[] Simcards=new string[0];
        public Mobile(byte SimCardsCount, double width, double height, double weight):base( width,  height, weight)
        {
            if (SimCardsCount==1 || SimCardsCount==2 )
                
            {
             Simcards = new string[SimCardsCount];
            }
            else
            {
              Console.WriteLine("sim cart sayi 2 den cox ola bilmez");
            }
            
            
        }
        public void AddNumber()
        {
            if (Simcards.Length==1 ) 
            {
                Console.WriteLine("nomre daxil edin:");
                string numfirst = Console.ReadLine();
                Simcards[Simcards.Length-1] = numfirst;
                Console.WriteLine("nomre daxil edildi");
            }
            else if (Simcards.Length==2)
            {
                Console.WriteLine("nomre daxil edin:");
                string numfirst = Console.ReadLine();
                string numsecond = Console.ReadLine();
                Simcards[Simcards.Length - 2] = numfirst;
                Simcards[Simcards.Length - 1] = numsecond;
                Console.WriteLine("nomreler daxil edildi");
            }
         
        }
        

        public void ShowNumbers()
        {
            for (int i = 0; i < Simcards.Length; i++)
            {
                Console.WriteLine($"{i} {Simcards[i]}");
               
            }
        }
        public void RemoveNumbers(int num)
        {

            //Simcards[num] = null;
            string[] newArr= new string[Simcards.Length-1];
            int j= 0;
            for (int i = 0; i < Simcards.Length; i++) 
            {
                if (i != num)
                {
                    newArr[j++] = Simcards[i];
                }
            }
            Simcards = newArr;
        }

    } 
}
