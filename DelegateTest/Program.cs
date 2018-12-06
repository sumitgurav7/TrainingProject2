using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    class Program
    {
        public delegate void gettingName(string fname, string lname);
        static void Main(string[] args)
        {
            gettingName del1 = new gettingName(fullName);
            gettingName del2 = new gettingName(fullName);
            del1("prashob", "M");
            del2("Vishal", "Singh");
            Console.ReadKey();
        }

        static  void fullName(string fnamw, string lname)
        {
            Console.WriteLine(fnamw+" "+ lname);
        }
    }
}
