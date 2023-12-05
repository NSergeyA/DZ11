using System;

namespace DZ11
{
    internal class DeveloperInfoAttribute
    {
        public string Dname;
        public DateTime Ddate;
        public DeveloperInfoAttribute(string dname, DateTime ddate)
        {
            Dname = dname;
            Ddate = ddate;
        }
        public DeveloperInfoAttribute(string dname)
        {
            Dname = dname;
        }

    }
}
