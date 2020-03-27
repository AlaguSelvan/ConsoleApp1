using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IndexerTut
    {
        private Dictionary<string, string> _dictionary;

        public void HttpCookie()
        {
            // similar to js objects
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

        public void UseCookie(string[] args)
        {
            var cookie = new IndexerTut();
            cookie["name"] = "Alex"
        }
    }
}
