using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    internal class Color : Printer
    {
        Random random;

        public Color()
        {
            random = new Random();
        }

        public override void Print(string value)
        {
            Console.ForegroundColor = (ConsoleColor)random.Next(0, 10);
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}