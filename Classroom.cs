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

        public void addPerson2Class(Person p)
        {
            this.persons.Add(p);
        }
        public void addAge2Class(Person a)
        {
            this.persons.Add(a);
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

        public void AddGPA2Class(Person g)
        {
            persons.Add(g);
        }

        public string GPAavg()
        {
            double totalGPA = 0;
            int count = 0;
            foreach (Person g in persons)
            {
                totalGPA += g.GetGPA();
                count++;
            }
            double avgGPA = totalGPA / count;
            return avgGPA.ToString();
        }

        public string minGPAName()
        {
            double totalGPA = 0;
            int count = 0;
            double minGPA = double.MaxValue;
            string name = "";
            foreach (Person g in persons)
            {
                double currentGPA = g.GetGPA();
                totalGPA += currentGPA;
                count++;
                if (currentGPA < minGPA)
                {
                    minGPA = currentGPA;
                    name = g.GetName();
                }
            }
            return name;
        }
        public string maxGPAName()
        {
            double totalGPA = 0;
            int count = 0;
            double maxGPA = 0;
            string name = "";
            foreach (Person g in persons)
            {
                double currentGPA = g.GetGPA();
                totalGPA += currentGPA;
                count++;
                if (currentGPA > maxGPA)
                {
                    maxGPA = currentGPA;
                    name = g.GetName();
                }
            }
            return name;
        }
    }
}
