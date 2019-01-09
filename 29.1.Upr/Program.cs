using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._1.Upr
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Teacher Petko = new Teacher();
            Petko.name = "Petar";
            Petko.paymentPerHour = 6.5;
            Petko.hoursPerWeek = 40;
            Petko.PaymentPerMonth();
            Petko.PrintInfo();

            Subject Himiya = new Subject();
            Himiya.name = "Chemistry";

            Subject Biologiya = new Subject();
            Biologiya.name = "Biology";

            Subject Istoriya = new Subject();
            Istoriya.name = "History";

            Subject Matematika = new Subject();
            Matematika.name = "Math";
        }
    }
}