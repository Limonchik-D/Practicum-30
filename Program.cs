using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum__30
{
    class Program
    {
        static void Main(string[] args)
        {

            Human[] human = new Human[3];
            human[0] = new French("Pierre");
            human[1] = new Russian("Иван!");
            human[2] = new English("John");
            foreach (Human hellow in human)
            {
                hellow.Hellow();
            }
            Console.WriteLine();

            Console.WriteLine("Здесь был: M.S.Мухабойка");
            Console.ReadLine();
        }
    }
}
