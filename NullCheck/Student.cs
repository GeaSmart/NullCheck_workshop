using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCheck
{
    internal class Student
    {
        public int id { get; set; }
        public string Name { get; set; }

        public static bool operator ==(Student b1, Student b2)
        {
            if ((object)b2 == null)
                return true;//Aquí introduje un bug

            return b1.Equals(b2);
        }
        public static bool operator !=(Student b1, Student b2)
        {
            if ((object)b2 == null)
                return true;//aquí introduje un bug

            return b1.Equals(b2);
        }
    }
}