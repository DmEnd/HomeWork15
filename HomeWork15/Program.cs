using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Арифметическая прогрессия");
            ArithProgression arProg = new ArithProgression();
            arProg.SetStart(10);
            arProg.SetStep(2);

            Console.WriteLine(arProg.GetNext());
            Console.WriteLine(arProg.GetNext());
            Console.WriteLine(arProg.GetNext());

            arProg.Reset();

            Console.WriteLine(arProg.GetNext());
            Console.WriteLine(arProg.GetNext());

            Console.WriteLine("Геометрическая прогрессия");
            GeomProgression geProg = new GeomProgression();
            geProg.SetStart(3);
            geProg.SetStep(2);

            Console.WriteLine(geProg.GetNext());
            Console.WriteLine(geProg.GetNext());
            Console.WriteLine(geProg.GetNext());

            geProg.Reset();

            Console.WriteLine(geProg.GetNext());
            Console.WriteLine(geProg.GetNext());

            Console.ReadKey();
        }
    }
}
