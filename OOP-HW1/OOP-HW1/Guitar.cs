using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG
{
    class Guitar
    {
        public Guitar(int numberOfFrets, int numberOfStrings, string color)
        {
            NumberOfStrings = numberOfStrings;
            GuitarString = new List<GuitarString> { };
            tuneStandard();
            Fretboard = new Fretboard("Maple");
            Fretboard.InitializeFrets(numberOfFrets, numberOfStrings);
            Color = color;
        }

        public string Color
        {
            get;
            private set;
        }

        public int NumberOfStrings
        {
            get;
            private set;
        }

        public int NumberOfFrets
        {
            get;
            private set;
        }

        public List<GuitarString> GuitarString;

        public Fretboard Fretboard;

        public void PrintBoard()
        {
            for (int i = Fretboard.frets.Count-1; i >= 0; i--)
            {
                Console.Write(GuitarString[i].Tone + "|");
                for (int j = 0; j < Fretboard.frets[i].Count; j++) Console.Write(Fretboard.frets[i][j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void tuneStandard()
        {
            GuitarString.Add(new GuitarString('E'));
            GuitarString.Add(new GuitarString('A'));
            GuitarString.Add(new GuitarString('D'));
            GuitarString.Add(new GuitarString('G'));
            GuitarString.Add(new GuitarString('B'));
            GuitarString.Add(new GuitarString('e'));
        }

        public void TuneDropD()
        {
            GuitarString.Add(new GuitarString('D'));
            GuitarString.Add(new GuitarString('A'));
            GuitarString.Add(new GuitarString('D'));
            GuitarString.Add(new GuitarString('G'));
            GuitarString.Add(new GuitarString('B'));
            GuitarString.Add(new GuitarString('e'));
        }

        public void PlaySampleChord()
        {
            Fretboard.frets[0][3] = 'X';
            Fretboard.frets[1][2] = 'X';
            Fretboard.frets[4][3] = 'X';
            Fretboard.frets[5][3] = 'X';
        }
    }
}
