using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCheck
{
    internal class StudentRepository
    {
        private List<Student> students = new List<Student>()
        {
            new Student() { id = 1, Name = "Gerson"},
            new Student() { id = 2, Name = "Yasmín"},
            new Student() { id = 3, Name = "Estefany"},
            new Student() { id = 4, Name = "Pery"},
            new Student() { id = 5, Name = "Guille"},
            new Student() { id = 6, Name = "Angel"},
            new Student() { id = 7, Name = "Rosa"}
        };

        public Student GetById(int id)
        {
            return students.Find(x => x.id == id);
        }
    }
}
