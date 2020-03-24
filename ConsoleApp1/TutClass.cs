using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PersonClass
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
    }
    class TutClass
    {
        public void StaticCheck()
        {
            var person = new PersonClass();
            person.Name = "Alagu";
            person.Introduce("");
        }
    }
}
