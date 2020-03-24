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
     }

    class ProgramMod
    { 
      public void Test()
        {
            var mod = new AccessModifiers();
        }
    }
}
