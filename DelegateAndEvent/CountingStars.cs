using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
   public class CountingStars
    {
        public event countingStars Counting;
        public event EventHandler Counted;

        public void startCounting(string str)
        {
            int counter = 0;
            foreach(char c in str)
            {
                if(c=='*')
                {
                    counter++;
                    onCounting(counter);
                }
            }
            onCounted();


        }

        public void onCounting(int count)
        {
            //CountingStars obj = new CountingStars();
            //obj.Counting += CountStartsEvent;
            var del = Counting as countingStars;
            if(del != null)
            {
                del(count);
            }
        }

        public void onCounted()
        {
            var del = Counted as EventHandler;
            if(del !=null)
            {
                del(this, EventArgs.Empty);
            }
        }

        //public static void CountStartsEvent(int i)
        //{
        //    Console.WriteLine(i);
        //}
    }
}
