using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fela1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Téglalap kerülete és területe");
            Console.Write("Kérem az a oldalt");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Kérem a b oldlat");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("A kerület: "+ 2 * a + 2 * b);
            double ker = 2 * a + 2 * b;
            double ter = a * b;
            Console.WriteLine($"A terület {ter}");
            if (ker == ter)
            {
                Console.WriteLine("Egyenlő");
            }
            else if (ker > ter)
            {
                Console.WriteLine("A kerület nagyobb");
            }
            else
            {
                Console.WriteLine("A terület nagyobb");

            Random rnd = new Random();

            Console.WriteLine("Tanár diák kocka játék");
            int tanar=rnd.Next(1,6);
            Console.WriteLine($"A tanár {tanar} dobott");
            int diak = rnd.Next(1, 6);
            Console.WriteLine($"A diák {diak} dobott");
            if (tanar > diak)
            {
                Console.WriteLine("A tanár nyert");

            }
            else if (tanar < diak)
            {
                Console.WriteLine("A diák nyert");

            }
            else
            {
                Console.WriteLine("hát");
            for (int i = 1;i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Hajrá zete!!!!");
            }
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Fújpest!!!!");
            }
            Console.Write("Kérem az a oldalt");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Kérem a b oldalt");
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Az A oldal nagyobb mint a B");
            }
            if (a < b)
            {
                Console.WriteLine("A B oldal nagyobb mint az A");
            }
           
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Hajrá zete!!!!");
                for (int i2 = 1; i2 <= 3; i2++)
                {
                    Console.WriteLine("Fújpest!!!!");
                }
            }
            string[] nevek = { "Anna", "Béla", "Csaba" };

            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine(nevek[i]);
            }
            string[] nevek = { "Anna", "Béla", "Csaba" };
            foreach (string nev in nevek)
            {
                Console.WriteLine(nev);
            }
            string[] cuccok = { "  |", "  |", "  V", "A legkomolyabb wingman" };
            foreach (string cnev in cuccok)
            {
                Console.WriteLine(cnev);

            }
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
            int[] szamok = { 12, 5, 8, -3 };
            int min = szamok[0];
            for (int i = 1; i < szamok.Length; i++)
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
            }
            Console.WriteLine("A legkissebb szám: " +min);

            int[] szamok = { 12, 5, 8, -3 };
            int min = szamok[0];
            foreach (int szam in szamok)
            { 
                if (szam < min)
                {
                    min = szam;
                }
            }
            Console.WriteLine(min);
            int[] szamok = { 12, 5, 8, -3 };
            int min = szamok[0];
            int i = 1;
            while (i < szamok.Length)
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
                i++;
            }
            Console.WriteLine("A legkissebb szám: " + min);*/

            int[] szamok = { 12, 5, 8, -3 };
            int min = szamok[0];
            int i = 1;
            do
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
                i++;
            }while (i < szamok.Length);
            Console.WriteLine("A legkissebb szám: " + min);


        }
    }
}

