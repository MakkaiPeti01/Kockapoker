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

        }
    }
}
