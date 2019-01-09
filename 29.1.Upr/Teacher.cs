using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._1.Upr
{
    internal class Teacher : Person
    {
        public double paymentPerHour;
        public int hoursPerWeek;
        public double salary;

        public void PaymentPerMonth()
        {
            this.salary = ((this.paymentPerHour * this.hoursPerWeek) * 4);
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.name + " makes  " + this.salary + " $ per month.");
        }
    }
}