using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personer
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            time.Sethour(5);
            int hour = time.GetHour();


        }
    }
}
