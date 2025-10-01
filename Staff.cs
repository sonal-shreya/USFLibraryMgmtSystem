using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USFLibraryMgmtSystem
{
    public class Staff: Person
    {
        public string Position { get; set; }
        public string Department { get; set; }

        public Staff()
        {
            Position = Position;
            Department = Department;
        }

    }
}
