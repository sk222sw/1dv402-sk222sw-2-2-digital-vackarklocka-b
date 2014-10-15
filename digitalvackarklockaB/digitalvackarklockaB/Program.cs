﻿using System;
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
            //Instansiera objekt av klassen AlarmClock - 
            //testa konstruktorerna, egenskaperna och metoderna.
            

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════════════════╗ ");
            Console.WriteLine(" ║           Väckarklockan              ║ ");
            Console.WriteLine(" ║        BEEP BEEP BEEP BEEP           ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            Console.ResetColor();
            Console.WriteLine();

            //testfest:

            //Test 2:
            AlarmClock ac = new AlarmClock(0, 0);
            ViewTestHeader("\n════════════════════════════════════════\n\nTest 1.\nTest av standardkonstruktorn.");
            Console.WriteLine(ac);

            ac = new AlarmClock(9, 42);
            ViewTestHeader("\n════════════════════════════════════════\n\nTest 2.\nTest av konstruktorn med två parametrar, <9, 42>.");
            Console.WriteLine(ac);

            ac = new AlarmClock(13, 24, 7, 35);
            ViewTestHeader("\n════════════════════════════════════════\n\nTest 3.\nTest av konstruktorn med fyra parametrar, <13, 24, 7, 35>.");
            Console.WriteLine(ac);

            ac = new AlarmClock(23, 58, 7, 35);
            ViewTestHeader("\n════════════════════════════════════════\n\nTest 4.\nStäller klockan till 23:58 och låter den gå 13 minuter.");
            Run(ac, 13);
            Console.WriteLine(ac);

            ac = new AlarmClock(6, 12, 6, 15);
            ViewTestHeader("\n════════════════════════════════════════\n\nTest 5.\nStäller tiden till 6:12 och alarmet till 6:15 och låter klockan gå 6 minuter.");
            Run(ac, 13);
            Console.WriteLine(ac);


        }
        private static void Run(AlarmClock ac, int minutes)
        {
            for (int i = 0; i < minutes; i++)
            {                
                if (ac.TickTock())
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0} BEEP BEEP", ac);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(ac);
                }
            }
        }


        private static void ViewTestHeader(string header)      //Används för att skriva ut meddelanden under testkörningen.
        {
            string horizontalLine = "════════════════════════════════════════";
            Console.WriteLine(horizontalLine);
            Console.WriteLine(header);
        }

    }
}
