using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG
{
    class Program
    {
        static void Main(string[] args)
        {
            Guitar guitar = new Guitar(23,6,"Starburst");
            guitar.PrintBoard();
            guitar.PlaySampleChord();
            guitar.PrintBoard();
            System.Threading.Thread.Sleep(3000);
        }
    }
}
