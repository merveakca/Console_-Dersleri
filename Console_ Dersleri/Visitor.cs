using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console__Dersleri
{
    class Visitor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public String City { get; set; }

        public void Mesaj(string p)
        {
            Console.WriteLine(p);
        }
    }
}
