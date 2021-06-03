using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tshepiso_Mohatlane__Project_1
{
    class ThreadTimer
    {
        public  static void Timer ()
        {

            for (int i = 100; i > 0; i--)
            {
                Thread.Sleep(1800);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
