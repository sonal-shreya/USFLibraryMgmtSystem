using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USFLibraryMgmtSystem
{
    public class Student : Person
    {
        public string Major { get; set; }
        public int GraduationYear { get; set; }

        public Student()
        {
            Major = Major;
            GraduationYear = GraduationYear;
        }
    }

}
