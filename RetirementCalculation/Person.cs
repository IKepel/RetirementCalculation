using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementCalculation
{
    public class Person
    {
        public delegate double PrintFunc(int age, int expeareance);

        public string Name { get; set; }

        public int Age { get; set; }

        public int Expeareance { get; set; }

        public Person(string name, int age, int expeareance)
        {
            Name = name;
            Age = age;
            Expeareance = expeareance;
        }

        public double GetRetirementValue(PrintFunc func)
        {
            double pension = func(Age, Expeareance);
            return pension;
        }
    }
}