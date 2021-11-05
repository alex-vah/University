using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{

    public class UniversityManager
    {
        public Teacher[] _teachers;
        public Student[] _students;
        public int _numOfTeachers = 0;
        public int _numOfStudents = 0;

        public UniversityManager(Student student, Teacher teacher, int numOfTeachers, int numOfStudents)
        {
            Teacher[] teachers = new Teacher[numOfTeachers];
            Student[] students = new Student[numOfStudents];
            for (int i = 0; i < numOfTeachers; i++)
            {
                teachers[i] = teacher;
            }
            for (int i = 0; i < numOfStudents; i++)
            {
                students[i] = student;
            }
            _teachers = teachers;
            _students = students;
            _numOfStudents = numOfStudents;
            _numOfTeachers = numOfTeachers;

        }
        public UniversityManager(Teacher teacher, Student student)
        {
            Student[] students = new Student[_numOfStudents + 1];
            Teacher[] teachers = new Teacher[_numOfTeachers + 1];
            for (int i = -1; i < _numOfTeachers; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    teachers[i] = _teachers[j];
                }
                teachers[i + 1] = teacher;

            }
            for (int i = -1; i < _numOfStudents; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    students[i] = _students[j];
                }
                students[i + 1] = student;
            }
            _students = students;
            _numOfStudents = _numOfStudents + 1;
            _teachers = teachers;
            _numOfTeachers = _numOfTeachers + 1;

        }
        public void AddTeacher(Teacher teacher)
        {
            Teacher[] teachers = new Teacher[_numOfTeachers + 1];
            for (int i = 0; i < _numOfTeachers; i++)
            {
                teachers[i] = _teachers[i];
                teachers[i + 1] = teacher;

            }
            _teachers = teachers;
            _numOfTeachers = _numOfTeachers + 1;
        }
        public void AddStudent(Student student)
        {
            Student[] students = new Student[_numOfStudents + 1];
            for (int i = 0; i < _numOfStudents; i++)
            {
                students[i] = _students[i];
                students[i + 1] = student;
            }
            _students = students;
            _numOfStudents = _numOfStudents + 1;
        }


        public void GetTeachersForStudents()
        {
            for (int i = 0; i < _numOfStudents; i++)
            {
                _students[i]._teacher = _teachers[i % _numOfTeachers];
            }

        }
        public void GetStudentsForTeachers(Teacher teacher)
        {
            int TeachersStudents = 0;
            for (int i = 0; i < _numOfTeachers; i++)
            {

                if (_students[i]._teacher == teacher)
                {
                    TeachersStudents++;
                }
            }

            Student[] students = new Student[TeachersStudents+1];
            int j = 0;
            for (int i = 0; i < _numOfStudents; i++)
            {
                if (_students[i]._teacher == teacher)
                {
                    students[j] = _students[i];
                    j++;
                }
            }
            teacher._students = students;
        }




    }
}
