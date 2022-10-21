using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class GoodPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Добре читання");
        }

        public override void Write()
        {
            Console.WriteLine("Добре писання");
        }

        public override void Relax()
        {
            Console.WriteLine("Хороший відпочинок");
        }

        public override void Study()
        {
            Console.WriteLine("Добре навчання");
        }
    }
}