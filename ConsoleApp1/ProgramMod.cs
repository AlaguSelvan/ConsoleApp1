using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   internal class AccessModifiers
    {

        /* without getter and setter
        private DateTime _birthdate;
        public void SetBirthDate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
        */
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
     }

    class ProgramMod
    { 
      public static void Test()
        {
            var mod = new AccessModifiers();
            mod.BirthDate = new DateTime(1997, 03, 14);
            Console.WriteLine(mod.Age);
        }
    }
}
