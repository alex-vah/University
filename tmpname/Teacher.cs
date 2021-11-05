using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Teacher
    {
        
        public Teacher(string name, int age)
        {
            _name = name;
            _age = age;
            _id = Guid.NewGuid();
        }
        public Guid _id;
        public int _age;
        public string _name;
        public Student[] _students;
    }
}
