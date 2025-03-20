using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum__30
{
    class French : Human
    {
        public French(string name) : base(name) { }
        public override void Hellow() 
        {
            Console.WriteLine($"Bonjour {Name}");

        }
        
    }
}
