using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class Classroom
    {
        private string name;
        private int age;
        private double Gpa;

        List<Person> persons = new List<Person>();

        public Classroom(string name)
        {
            this.name = name;
        }
        public Classroom(int age)
        {
            this.age = age;
        }
        public Classroom()
        {
            this.Gpa = Gpa;
        }

        public void addPerson2Class(Person p)
        {
            this.persons.Add(p);
        }
        public void addAge2Class(Person a)
        {
            this.persons.Add(a);
        }
        public void addGPaAlll2Class(Person g)
        {
            this.persons.Add(g);
        }

        public string showAllPersoninClass()
        {
            string result = "";
            foreach (Person p in this.persons)
            {
                result += p.GetName() + "\r\n";
            }
            return result;
        }
        public string showAllAgePerson()
        {
            string result1 = "0";
            foreach (Person a in this.persons)
            {
                result1 = a.GetAge() + "\r\n";

            }
            return result1;


        }
        public string showAllGPaPerson()
        {
            string result = "";
            foreach (Person g in this.persons)
            {
                result += g.GetGPA() + "\r\n";
            }
            return result;
        }
    }
}
