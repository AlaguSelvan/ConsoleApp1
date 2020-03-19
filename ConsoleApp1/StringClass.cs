using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class StringClass
    {
        public void Excercise1()
        {
            string s1 = "Hello ";
            string s2 = "World";
            string rows = "Row 1\r\nRow 2\r\nRow 3";
            string title = "\"The \u00C6olean Harp\", by Samuel Taylor Coleridge";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(rows);
            Console.WriteLine(title);
        }

        public static string SummarizeText(string text, int maxLength = 30)
        {
            Console.WriteLine("Text Length is:", text.Length);
            Console.WriteLine("maxLength is:", maxLength);
            if (text.Length <= maxLength)
                return text;
            else
            {
                var words = text.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();
                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length;
                    if (totalCharacters > maxLength)
                        break;
                }
                Console.WriteLine(String.Join(" ", summaryWords) + "...");
                return String.Join(" ", summaryWords) + "...";
            }
        }
    }
}
