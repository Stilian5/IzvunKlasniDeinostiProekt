using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzvunklasnIDeinostiProekt
{
    public class SchoolData
    {
        private List<Student> students;

        public SchoolData()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DisplayAllStudents()
        {
            foreach (var student in students)
            {
                student.DisplayInformation();
                Console.WriteLine();
            }
        }
        public void DisplayStudentByName(string name)
        {
            var query = from student in students where student.Name == name select student;
            if (students != null)
            {
                students[0].DisplayInformation();
            }

        }
        public void CalculateStatistics()
        {
            int totalStudents = students.Count;
            int totalSIPs = students.Count(x => x.AttendsSIP());
            int totalNonSEPs = totalStudents - totalSIPs;

            Console.WriteLine($"Total Students: {totalStudents}");
            Console.WriteLine($"Total SEPs: {totalSIPs}");
            Console.WriteLine($"Total Non-SEPs: {totalNonSEPs}");
        }
        public void DisplayStudentWithHighestSredenUspeh()
        {
            students.OrderByDescending(x => x.SrUspeh).ToList().ForEach(x => Console.WriteLine(x + " "));
        }

   
    }
}

