using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03._2
{
    class GoodPupil : Pupil
    {
        public override void Write()
        {
            Console.WriteLine("Good 2 hours");
        }

        public override void Study()
        {
            Console.WriteLine("3 hours");
        }

        public override void Relax()
        {
            Console.WriteLine("2 hours");
        }

        public override void Read()
        {
            Console.WriteLine("2 hours");
        }
    }
}
