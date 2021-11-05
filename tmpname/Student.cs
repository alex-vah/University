using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Student
    {
        
        public Student(string name, int age)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
        }
        
        public Guid _id;
        public int _age;
        public string _name;
        public Teacher _teacher;
    }
}
