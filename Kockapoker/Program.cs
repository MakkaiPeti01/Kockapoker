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
        static void Ellenorzes()
        {
            StreamReader olvas = new StreamReader("Teszteles.txt");
            while (!olvas.EndOfStream)
            {
                string[] a = olvas.ReadLine().Split(',');
            List<int> sz = a.Select(x => int.Parse(x)).ToList();
            Dobas d = new Dobas(sz[0], sz[1], sz[2], sz[3], sz[4]);
            d.Kiiras();
            }
        }
        static void Main(string[] args)
        {
            //d.EgyDobas();
            //d.Kiiras();
            //Console.WriteLine(d.Erteke());
            //Ellenorzes();
            Dobas gep = new Dobas();
            Dobas ember = new Dobas();
            Console.WriteLine("Gép:");
            gep.EgyDobas();
            gep.Kiiras();

            Console.WriteLine("Ember: ");
            ember.EgyDobas();
            ember.Kiiras();
            if (gep.Pont > ember.Pont) 
            {
                Console.WriteLine("Gép nyert");
            }
            else if (ember.Pont > gep.Pont)
            {
                Console.WriteLine("Ember nyert");
            }
            else
            {
                Console.WriteLine("Döntetlen");
            }
            Console.ReadKey();
        }
    }
}
