using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzvunklasnIDeinostiProekt
{
    public abstract class Student
    {
        public string Name { get; set; }
        public int Class { get; set; }
        public string Paralelka { get; set; }
        public double SrUspeh { get; set; }

        public abstract bool AttendsSIP();
        public virtual void DisplayInformation()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: {Class}");
            Console.WriteLine($"Paralelka: {Paralelka}");
            Console.WriteLine($"Sreden Uspeh: {SrUspeh}");
        }
    }
}
