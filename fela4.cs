using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fela2
{
    internal class Program
    {
        
        static void kiirat()
        {
            Console.WriteLine("Hello Premo");
        }
        
        static void kiirat1(string nev)
        {
            Console.WriteLine(nev + " Hello");
        }
        static void kiirat2(string nev, int kor)
        {
            Console.WriteLine(nev + " Hello " + kor + " éves");
        }
        static void kiirat3(string iskola = "Premo")
        {
            Console.WriteLine("Hello " + iskola);
        }
        static void szam()
        {
            Console.WriteLine("Kérem a négyzet oldalát! ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine("A négyzet területe " + szam*szam);
        }
        static int szamol()
        {
            Console.WriteLine("Kérem a négyzet oldalát! ");
            int szam = int.Parse(Console.ReadLine());
            int ter = szam * szam;
            return ter;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("A négyzet területe: " + szamol());



        }
    }
}
