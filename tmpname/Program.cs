using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("a", 20);
            Student student2 = new Student("b", 21);
            Student student3 = new Student("c", 22);
            Student student4 = new Student("d", 19);
            Teacher teacher1 = new Teacher("x", 30);
            Teacher teacher2 = new Teacher("y", 40);
            UniversityManager manager = new UniversityManager(teacher1, student1);
            manager.AddStudent(student2);
            manager.AddStudent(student3);
            manager.AddStudent(student4);
            manager.AddTeacher(teacher2);
            manager.GetTeachersForStudents();
            manager.GetStudentsForTeachers(teacher1);
            manager.GetStudentsForTeachers(teacher2);
        }
    }
}
