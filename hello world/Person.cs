using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
     public class Person
    {
        public string FirstName;
        public string Lastname;
        public String ok = ("OK");
        public void Introduce()
        {
            var ook = new bool[2];
            Console.WriteLine("My name is " + FirstName + " " + Lastname);
            Console.WriteLine(ok);
        }

    }  
}
