using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Example ex = new Example();
            ex.set(11);
            int p= ex.get();
            Console.WriteLine(p);
           
            Person pp = new Person();
            pp.ves = 90;
            pp.Name = "Pikosh";
            pp.Surname = "Happiness";
            pp.ves = pp.loseVes(10);
            Employee e = new Employee();
            Console.WriteLine(pp.ShowFullName("Muhitovna"));
            Console.WriteLine(pp.ves);


        }
    }
}







































































































































































