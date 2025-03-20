using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum__30
{
    class Russian : Human
    {
        /// <summary>
        /// Контруктор класса Russian
        /// </summary>
        /// <param name="name"></param>
        public Russian (string name) : base(name) { }
        /// <summary>
        /// Переопределенный метод приветствия
        /// </summary>
        public override void Hellow()
        {
            Console.WriteLine($"Привет {Name}");
        }
    }
}
