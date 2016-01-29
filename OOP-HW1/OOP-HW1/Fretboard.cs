using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG
{
    class Fretboard
    {
        public Fretboard()
        {
            frets = new List<List<char>> { };
        }

        public List<List<char>> frets;

        public void InitializeFrets(int numberOfFrets, int numberOfStrings)
        {
            for (int i = 0; i < numberOfStrings; i++)
            {
                frets.Add(new List<char> { });
                for (int j = 0; j < numberOfFrets; j++)
                {
                    frets[i].Add('-');
                }
            } 
        }
    }
}
