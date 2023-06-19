using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzvunklasnIDeinostiProekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolData dataOperations = new SchoolData();
            dataOperations.AddStudent(new SipStudents
            {
                Name = "John Smith",
                Class = 10,
                Paralelka = "A",
                SrUspeh = 3.5,
                Zip = "12345",
                Sip = "67890"
            });

            dataOperations.AddStudent(new NonSipStudents
            {
                Name = "Emily Johnson",
                Class = 11,
                Paralelka = "B",
                SrUspeh = 3.2
            });

            Console.WriteLine("All Students:");
            dataOperations.DisplayAllStudents();
            Console.WriteLine();

            Console.WriteLine("Student by Name:");
            dataOperations.DisplayStudentByName("John Smith");
            Console.WriteLine();

            Console.WriteLine("Statistics:");
            dataOperations.CalculateStatistics();
            Console.WriteLine();

            Console.WriteLine("Students with highest SrUspeh:");
            dataOperations.DisplayStudentWithHighestSredenUspeh();
            Console.WriteLine();


        }
    }
}
