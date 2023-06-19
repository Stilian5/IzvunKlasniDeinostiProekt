using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzvunklasnIDeinostiProekt
{
    internal class NonSipStudents:Student
    {
        public override bool AttendsSIP()
        {
            return false;
        }
    }
}
