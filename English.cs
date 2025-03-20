using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum__30
{
    class English : Human
    {
        /// <summary>
        /// Конструктор класса English
        /// </summary>
        /// <param name="name"></param>
        public English(string name) : base( name) { }

        /// <summary>
        /// Метод для вывода приветствия на английском
        /// </summary>
        public override void Hellow()
        {
            Console.WriteLine($"Hello {Name}");
        }
    }
}
