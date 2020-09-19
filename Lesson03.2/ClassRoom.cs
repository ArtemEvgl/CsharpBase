using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03._2
{
    class ClassRoom
    {
        Pupil[] pupils;
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupils = new Pupil[3];
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = pupil3;           
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupils = new Pupil[4];
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = pupil3;
            pupils[3] = pupil4;
        }

        public void ShowStudy()
        {
            
            foreach (var pupil in pupils)
            {
                Console.Write($"{pupil.GetType().Name}");
                pupil.Study();
                pupil.Relax();
                pupil.Read();
                pupil.Write();
            }
        }


    }
}
