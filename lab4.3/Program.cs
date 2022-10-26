using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._3
{
  class Printer
  { 
        static void Main(params string[] value)
        {
            Console.SetCursorPosition(0,0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Привiт");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Мене звати Валерiя");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("А тебе?");

            Console.ReadKey();
        }
  }
   
}
