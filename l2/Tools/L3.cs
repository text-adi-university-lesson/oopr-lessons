using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2.Tools
{
    interface IL3_1
    {
        void Print();

    }
    interface IL3: IL3_1
    {
        string this[int index] { get; set; }
        int Count { get; }
        string Value { get; set; }
    }
    internal class L3: IL3
    {
        private string data;
        private List<string> _strings = new List<string>();
        public string Value {
            get { return data;  }
            set { data = value.ToString(); }
        }
        
        public string this[int index]
        {
            get => _strings[index];
            set
            {
                if (index >= 0 && index < _strings.Count)
                    _strings[index] = value;
            }
        }
        public void Print()
        {
            Console.WriteLine(this._strings);
        }
        public int Count => _strings.Count;

        public void Add(string item)
        {
            _strings.Add(item);
        }

    }
}
