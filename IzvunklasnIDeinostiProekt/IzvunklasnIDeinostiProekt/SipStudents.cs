using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzvunklasnIDeinostiProekt
{
    public class SipStudents:Student
    {
        public string Zip { get; set; }
        public string Sip { get; set; }

        public override bool AttendsSIP()
        {
            return true;
        }

        public override void DisplayInformation()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: {Class}");
            Console.WriteLine($"Paralelka: {Paralelka}");
            Console.WriteLine($"Sreden Uspeh: {SrUspeh}");
            Console.WriteLine($"Zip: {Zip}");
            Console.WriteLine($"Sip: {Sip}");
        }
    }
}
