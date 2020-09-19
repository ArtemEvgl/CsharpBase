using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03._2
{
    class ExcelentPupil : Pupil
    {
        public override void Write()
        {
            Console.WriteLine("3 hours");
        }

        public override void Study()
        {
            Console.WriteLine("4 hours");
        }

        public override void Relax()
        {
            Console.WriteLine("1 hours");
        }

        public override void Read()
        {
            Console.WriteLine("3 hours");
        }
    }
}
