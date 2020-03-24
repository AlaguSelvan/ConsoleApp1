using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StringBuilderClass
    {
        public void Excercise1()
        {
            var builder = new StringBuilder();
            builder.Append('-', 10).AppendLine().Append("Header").Replace('-', '+').Remove(0, 10).Insert(0, new string('=', 8));
            
            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]);
        }
    }
}
