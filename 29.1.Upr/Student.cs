using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._1.Upr
{
    internal class Student : Person
    {
        public string facNum;
        public string specialty;
        public Subject[] subjects = new Subject[3];
        public double sborOcenki;
        public Student[] students = new Student[100];

        public void AverageGrade()
        {
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine("Please enter grade for " + subjects[i].name);
                subjects[i].grade = double.Parse(Console.ReadLine());
                sborOcenki += subjects[i].grade;
            }
            sborOcenki /= 3;
            // Console.Write("Arithmetic mean is: " + sborOcenki);
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.name + "'s facultee number is: " + this.facNum);
            Console.WriteLine(this.name + "'s specialty is " + this.specialty);
            Console.Write("Arithmetic mean from" + this.name + "'s grades is: " + this.sborOcenki);
        }

        public void PrintGrades()
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (sborOcenki >= 4.5)
                {
                    Console.WriteLine(this.name + " gets scholarship with grades of: " + this.sborOcenki);
                }
            }
        }
    }
}