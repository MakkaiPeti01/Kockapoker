using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kockapoker
{
    class Program
    {
        static void Main(string[] args)
        {
            Dobas d = new Dobas(1,1,1,2,3);

           // d.EgyDobas();
            d.Kiiras();
            Console.WriteLine(d.Erteke());
            Console.ReadKey();
        }
    }
}
