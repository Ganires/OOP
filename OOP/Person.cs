using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace OOP
{
    public  class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double ves { get; set; }
        public int rost { get; set; }

        public double loseVes (int km)
        {
            return ves - (0.1 * km);
        }
        public void ShowFullName()
        {
            Console.WriteLine(Name + " " + Surname);
        }
        public string ShowFullName(string FatherName)
        {
            return Name + " " + Surname+" "+ FatherName;
        }
        public void ShowFullName(string FatherName, string MatherName)
        {
            Console.WriteLine(Name + " " + Surname + " " + FatherName+" "+ MatherName);
        }

    }
    public class Employee : Person
    { 
        public int qq()
        {
            return 1;

        }
    }
}
