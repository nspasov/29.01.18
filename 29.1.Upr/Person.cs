using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._1.Upr
{
    internal class Person
    {
        public string name;
        public int age;
        public string egn;
        public string sex;

        public void PrintInfo()
        {
            Console.WriteLine("Person's name is: " + this.name + ".");
            Console.WriteLine(this.name + " is " + this.age + " years old" + this.sex + ".");
            Console.WriteLine(this.name + "'s EGN is: " + this.egn + ".");
        }
    }
}