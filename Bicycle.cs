using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_5
{
    class Bicycle:Vehicle,IRideable,IMusic
    {
        public void Ride()
        {
            Console.WriteLine("Jade rowerem");
        }
        public void PlayMelody()
        {
            Console.Beep();
            Console.WriteLine("Dryn");

        }
    }
}
