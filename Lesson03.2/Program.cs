using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03._2
{
    class Program
    {
        static void Main(string[] args)
        {
            BadPupil bp = new BadPupil();
            GoodPupil gp = new GoodPupil();
            ExcelentPupil ep = new ExcelentPupil();
            ClassRoom cr = new ClassRoom(bp, gp, ep);
            cr.ShowStudy();
            Console.ReadKey();
        }
    }
}
