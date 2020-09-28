using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Lesson12._2
{
    class Model
    {
        int seconds = 0;

        public int Tick()
        {
            return seconds++;
        }

        public int Reset()
        {
            seconds = 0;
            return seconds;
        }

    }
}
