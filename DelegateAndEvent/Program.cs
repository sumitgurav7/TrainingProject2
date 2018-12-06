using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    public delegate void countingStars(int stars);
    class Program
    {
        static void Main(string[] args)
        {

            CountingStars obj = new CountingStars();
           
            
            obj.Counting += CountStartsEvent;
            obj.startCounting("***************************************");
            Console.ReadKey();


        }


        public static void CountStartsEvent(int i)
        {
            Console.WriteLine(i);
        }
    }
}
