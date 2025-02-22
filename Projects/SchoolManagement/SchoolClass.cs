using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class SchoolClass
    {
        public string ClassName { get; set; }
        public List<string> Subjects { get; set; }

        public SchoolClass(string className, List<string> subjects)
        {
            ClassName = className;
            Subjects = subjects;
        }
    }
}