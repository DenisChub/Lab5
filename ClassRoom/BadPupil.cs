using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class BadPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Погане читання");
        }

        public override void Write()
        {
            Console.WriteLine("Погане писання");
        }

        public override void Relax()
        {
            Console.WriteLine("Поганий відпочинок");
        }

        public override void Study()
        {
            Console.WriteLine("Погане навчання");
        }
    }
}