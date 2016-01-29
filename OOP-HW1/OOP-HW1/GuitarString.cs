using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG
{
    class GuitarString
    {
        public GuitarString(char tone)
        {
            Tone = tone;
        }

        public char Tone
        {
            get;
            private set;
        }
    }
}
