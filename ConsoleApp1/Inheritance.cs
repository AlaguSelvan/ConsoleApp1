using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Inheritance
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public void Copy()
        {
            Console.WriteLine("Object Copied to ClipBoard");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object was Duplicated");
        }
        public void addText()
        {
            var text = new Text();   
            text.width = 100;
        }
    }
    public class PresentationObject
    {
        public int width { get; set; }
        public string height { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("We added a link to" + url);
        }

    }
    // Inheritance is Referenced with : in Csharp
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
        public void AddHyperLink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }

}
