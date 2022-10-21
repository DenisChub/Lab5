using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class ExcelentPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Відмінне читання");
        }

        public override void Write()
        {
            Console.WriteLine("Відмінне писання");
        }

        public override void Relax()
        {
            Console.WriteLine("Відмінний відпочинок");
        }

        public override void Study()
        {
            Console.WriteLine("Відмінне навчання");
        }
    }
}