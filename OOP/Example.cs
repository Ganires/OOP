using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Example
    {
        private int sum;
        public void set(int x)
        {
            if (x > 10)
            {
                Console.WriteLine("цифра не должна привышать 10");
            }
            else
            {
                sum = x;
            }
        }
        public int get()
        {
            return sum;
        }
    
       
    }
}
