using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03._2
{
    class BadPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("1 hour in day");
        }

        public override void Relax()
        {
            Console.WriteLine("5 hour in day");
        }

        public override void Study()
        {
            Console.WriteLine("30 mins in day");
        }

        public override void Write()
        {
            Console.WriteLine("13 minutes in day");
        }
    }
}
