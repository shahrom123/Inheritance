using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Service
{
    public class Person :Object
    {
        protected string _name;
        protected string _addres;

        public Person(string name, string addres)
        {
            _name = name;
            _addres = addres;
        }
        public string GetName()
        {
            return _name; 
        }
        public string GetAddres() 
        {
            return _addres; 
        }

        public void SetAddres(string addres)
        {
            _addres = addres;
        }
        public override string ToString()
        {
            return _name + _addres;  
        }
    }
}
