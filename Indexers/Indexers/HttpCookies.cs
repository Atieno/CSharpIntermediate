using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class HttpCookies
    {
        private readonly Dictionary<string, string> _dictionary; //generic class and parameters respectively

        public HttpCookies()
        {
            _dictionary = new Dictionary<string, string>();
        }
        //implimentation: deligate to the dictionary
        public string this[string key] { 
            get{ return _dictionary[key]; }
        
        set{ _dictionary[key] = value; }
        }

    }
}
