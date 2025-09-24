using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fela2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Kérem a kódot");
            string a = Console.ReadLine();
            a = a.ToLower();

            List<string> Km = new List<string> {};

            Km.Add(a);*/

            Console.WriteLine("Kérem a kódot");
            string b = Console.ReadLine();
            int szam = 0;
            Console.WriteLine(b);
            bool cU = false, cG = false, cF = false, cK=false;

            foreach (char c in b)
            {
                switch(c)
                {
                    case 'u': szam += 1; cU = true; break;
                    case 'g': szam += 1; cG= true; break;
                    case 'f': szam += 2; cF = true; break;
                    case 'k': szam += 10; cK= true; break;
                }
                

            }

            if (cU == true && cG == true && cF == true && cK == true)
            {
                szam += 10;
                Console.WriteLine("A szám: " + szam);
            }
            else
            {
                Console.WriteLine("plussz pont nem jár");
            }

            /*
            foreach (char i in a)
            {
                if (i == 'u')
                {
                    szam += 1;
                }
                else if (i == 'g')
                {
                    szam += 1;
                }
                else if (i == 'f')
                {
                    szam += 2;
                }
                else if (i == 'k')
                {
                    szam += 10;
                }
                else
                {
                    Console.WriteLine("Ez gyatya");
                }
                
            }
            Console.WriteLine(szam);*/


        }
    }
}
