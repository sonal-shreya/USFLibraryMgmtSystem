using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USFLibraryMgmtSystem
{
    public class Person
    {
        public string Name;
        public string EmailId;
        public string id;


        public Person()
        {
            Name = Name;
            EmailId = EmailId;
            id = id;
        }

        public string getName()
        {
            return Name;
        }
        public void setName(string name)
        {
            Name = name;

        }
        public string getEmailId()
        {
            return EmailId;
        }
        public void setEmailId(string EmailId)
        {
            EmailId = EmailId;

        }

        public string getId()
        {
            return id;
        }
        public void setId(string id)
        {
            id = id;
        }
    }
}
