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
            AlarmClock ac = new AlarmClock(9, 42);
            ViewTestHeader("\n════════════════════════════════════════\n\nTest 2.\nTest av konstruktorn med två parametrar, <9, 42>.");
            Run(ac, 4);
            Console.WriteLine("\n{0}\n", ac);

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
                Console.WriteLine(ac);
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
