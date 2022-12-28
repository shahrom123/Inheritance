

namespace Inheritance.Service
{
    public class Student : Person
    {
        private int _numCourses = 0;
        private List<string> Course;
        private List<int> Grades;

        public Student(string name , string addres) : base(name, addres)
        {
            Course = new List<string>();
            Grades = new List<int>();
        }       
        public void AddCouseGrade(string course, int grade)
        {
            Course.Add(course);
            Grades.Add(grade);          
        }
        public void PrintGrades()
        {
            foreach (var item in Grades)
            {
                Console.Write(item +  "  " );
            }
        }
        public double GetAvaregeGrade()
        {
            return Grades.Sum()/Grades.Count(); 
        }

        public override string ToString()
        {
            return _name + _addres;
        }

    }
}