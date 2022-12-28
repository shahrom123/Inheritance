using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Service
{
    public class Teacher:Person
    {
        private int _numCourses = 0;
        private List<string> _courses;

        public Teacher(string name, string addres) : base(name, addres)
        {
            _courses = new List<string>();
        }
        public  void PrintCourse()
        {
            foreach (var item in _courses)
            {
                Console.Write(item + ' ' );

            }
        }
        public bool AddCourse(string course)
        {
            foreach (var item in _courses)
            {
                if (item == course)
                {
                    _numCourses++;
                }

            }
            if (_numCourses > 0)
            {
                return false;
            }
            else
            {
                _courses.Add(course);
                return true;
            }   
        }

        public bool RemoveCourse(string course)
        {
            _numCourses = 0;

            foreach (var item in _courses)
            {


                if (item == course)
                {
                    _numCourses++;
                }

            }
            if (_numCourses == 0)
            {
                return false;
            }
            else
            {
                _courses.Remove(course);
                return true;
            }
        }
     
        public override string ToString()
        {
            return _name + _addres;
        }
    }
}
