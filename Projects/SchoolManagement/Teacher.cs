using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Teacher
    {
        public Guid Id { get; private set; }
        public string FullName { get; set; }
        public List<string> Subjects { get; set; }
        public string RoomNumber { get; set; }

        public Teacher(string fullName, List<string> subjects, string roomNumber)
        {
            Id = Guid.NewGuid();
            FullName = fullName;
            Subjects = subjects;
            RoomNumber = roomNumber;
        }
    }
}
