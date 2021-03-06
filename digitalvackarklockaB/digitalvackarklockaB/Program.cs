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
            string horizontalLine = "\n══════════════════════════════════════════\n";            



            //testfest:

            //Test 1:
            AlarmClock ac = new AlarmClock(0, 0);
            ViewTestHeader("Test 1.\nTest av standardkonstruktorn.");
            Console.WriteLine(ac);
            Console.WriteLine(horizontalLine);

            //Test 2:
            ac = new AlarmClock(9, 42);
            ViewTestHeader("Test 2.\nTest av konstruktorn med två parametrar, <9, 42>.");
            Console.WriteLine(ac);
            Console.WriteLine(horizontalLine);

            //Test 3:
            ac = new AlarmClock(13, 24, 7, 35);
            ViewTestHeader("Test 3.\nTest av konstruktorn med fyra parametrar, <13, 24, 7, 35>.");
            Console.WriteLine(ac);
            Console.WriteLine(horizontalLine);

            //Test 4:
            ac = new AlarmClock(23, 58, 7, 35);
            ViewTestHeader("Test 4.\nStäller klockan till 23:58 och låter den gå 13 minuter.");
            Run(ac, 13);
            Console.WriteLine(horizontalLine);

            //Test 5:
            ac = new AlarmClock(6, 12, 6, 15);
            ViewTestHeader("Test 5.\nStäller tiden till 6:12 och alarmet till 6:15 och låter klockan gå 6 minuter.");
            Run(ac, 6);
            Console.WriteLine(horizontalLine);

            //Test 6:
            ViewTestHeader("Test 6.\nTestar egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.\n");
            try
            {
                ac.Hour = 24;
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
            try
            {
                ac.Minute = 60;
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
            try
            {
                ac.AlarmHour = 24;
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
            try
            {
                ac.AlarmMinute = 60;
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
            Console.WriteLine(horizontalLine);

            //Test 7:
            ViewTestHeader("Test 7.\nTestar egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.");
            try
            {
                AlarmClock test7 = new AlarmClock(-1, -2);
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
            try
            {
                AlarmClock test7 = new AlarmClock(-1, 2, 2, 1);
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            Console.WriteLine(horizontalLine);

        }
        private static void Run(AlarmClock ac, int minutes)     //Körs TickTock() och hämtas för att få tiden att gå.
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
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════════════════╗ ");
            Console.WriteLine(" ║           Väckarklockan              ║ ");
            Console.WriteLine(" ║        BEEP BEEP BEEP BEEP           ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(header);
            Console.WriteLine();

        }

        private static void ViewErrorMessage(string message)    //Metod som används för att skriva ut felmeddelanden.
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }


    }
}
