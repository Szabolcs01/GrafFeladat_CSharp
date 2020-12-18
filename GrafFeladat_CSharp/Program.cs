﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafFeladat_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var graf = new Graf(6);

            graf.Hozzaad(0, 1);
            graf.Hozzaad(1, 2);
            graf.Hozzaad(0, 2);
            graf.Hozzaad(2, 3);
            graf.Hozzaad(3, 4);
            graf.Hozzaad(4, 5);
            graf.Hozzaad(2, 4);
            


            Console.WriteLine(graf);
            Console.WriteLine("szélességi bejárás 0 kezdőpontból:");
            graf.Szelesseg(0);
            Console.WriteLine("mélységi bejárás 0 kezdőpontból:");
            graf.Melyseg(0);
            Console.WriteLine("a gráf összefüggősége: "+graf.Osszefuggo());
            Console.ReadLine();
            
        }
    }
}
