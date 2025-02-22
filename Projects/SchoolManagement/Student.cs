using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Student
    {
        public Guid Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClassName { get; set; }
        public Dictionary<string, int> Grades { get; set; }

        public Student(string firstName, string lastName, string className)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            ClassName = className;

            Grades = new Dictionary<string, int>();
        }
    }
}
