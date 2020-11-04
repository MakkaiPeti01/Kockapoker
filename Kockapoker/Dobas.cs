using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockapoker
{
    class Dobas
    {
        int[] kockak = new int[5];

        public Dobas()
        {

        }
        public Dobas(int k1, int k2, int k3, int k4, int k5)
        {
            kockak[0] = k1;
            kockak[1] = k2;
            kockak[2] = k3;
            kockak[3] = k4;
            kockak[4] = k5;
        }
        public void EgyDobas()
        {
            Random vel = new Random();
            for (int i = 0; i < kockak.Length; i++)
            {
                kockak[i] = vel.Next(1, 7);
            }
        }

        public void Kiiras()
        {
            foreach (var i in kockak)
            {
                Console.Write($"{i} ");
            }
        }

        public string Erteke()
        {
            string r = "";
            Dictionary<int, int> eredmeny = new Dictionary<int, int>();
            for (int i = 1; i <= 6; i++)
            {
                eredmeny.Add(i, 0);
            }
            foreach (var i in kockak)
            {
                eredmeny[i]++;
            }
            if (eredmeny.ContainsValue(5))
            {
                r = "Nagypóker";
            }
            else if (eredmeny.ContainsValue(4))
            {
                r = "Póker";
            }
            else if (eredmeny.ContainsValue(3))
            {
                r = "Drill";
            }
            else if (eredmeny.ContainsValue(4))
            {
                r = "Pár";
            }
            return r;
        }
    }
}
