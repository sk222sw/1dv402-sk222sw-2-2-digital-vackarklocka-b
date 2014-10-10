using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalvackarklockaB
{
    class Program
    {
        static void Main(string[] args)
        {

            //testfest
        }
        private static void Run(AlarmClock ac, int minutes)
        {
            for (int i = 0; i < minutes; i++)
            {
                //if (ac.TickTock())
                //{
                //    Console.BackgroundColor = ConsoleColor.Blue;
                //    Console.ForegroundColor = ConsoleColor.White;
                //    Console.WriteLine("{0} BEEP BEEP", ac;
                //    Console.ResetColor();
                //}
                //else
                //{
                //    Console.WriteLine(ac);
                //}
                Console.WriteLine(ac);
            }
        }


        private static void ViewTestHeader(string header)      //Används för att skriva ut meddelanden under testkörningen.
        {
            Console.WriteLine(header);
        }

    }
}
