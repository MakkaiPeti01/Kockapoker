﻿using System;
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
            Dobas d = new Dobas();

            d.EgyDobas();
            d.Kiiras();

            Console.ReadKey();
        }
    }
}
