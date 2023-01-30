using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{ 
    public class Person
    {
        private string name;
        private int age;
        private int birtYear;
        private double GPA;

        public Person(string name, int bYear, double gPA)
        {
            this.name = name;
            this.birtYear = bYear;
            this.age = 2565 - bYear;
            this.GPA = gPA;
        }
        public int GetAge()
        {
            return this.age;
        }
        public string GetName()
        {
            return this.name;
        }
        public double GetGPA()
        {
            return this.GPA;
            
        }
    }
}
