using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            Console.WriteLine("A legkissebb szám: " + min);

          
            int[] szamok = { 12, 5, 8, -3 };
            /*
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

            int min1 = szamok.Min();

            Console.WriteLine($"A legkissebb szám {min1}");

            int max = szamok[0];
            
            
            for (int i2=1; i2 < szamok.Length; i2++)
            {
                if (szamok[1] > max)
                {
                    max = szamok[1];
                }
            }
            Console.WriteLine($"A legnagyobb szám: {max}");

            int max = szamok[0];

            foreach (int szam in szamok)
            {
                if (szam > max)
                {
                    max = szam;
                }
            }
            Console.WriteLine($"A legnagyobb szám: {max}");

            int max = szamok[0];
            int i = 1;
            while (i < szamok.Length)
            {
                if (szamok[i] > max)
                {
                    max = szamok[i];
                }
                i++;
            }
            Console.WriteLine($"A legnagyobb szám: {max}");
            int max = szamok[0];
            int i = 1;

            do
            {
                if (szamok[i] > max)
                {
                    max = szamok[i];
                }
                i++;
            }
            while (i < szamok.Length);

            Console.WriteLine($"A legnagyobb szám: {max}");

            int max1 = szamok.Max();

            Console.WriteLine($"A legnagyobb szám {max1}");

            List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett = 16;
            bool megtalalva = false;

            for (int i = 1; i < szamok.Count; i++)
            {
                if (szamok[i] == keresett)
                {
                    Console.WriteLine($"A keresett szám: ({keresett}) megtalálva a(z) {i}. indexen");
                    megtalalva = true;
                    break;
                }
            }
            if (!megtalalva)
            {
                Console.WriteLine($"A {keresett} szám nincs a listában");


            List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett = 16;
            bool megtalalva = false;
            int index = 0;

            foreach (int szam in szamok)
            {
                if (szam == keresett)
                {
                    Console.WriteLine($"A keresett szám: ({keresett}) megtalálva a(z) {index}. indexen");
                    megtalalva = true;
                    break;
                }
                index++;
            }

            if (!megtalalva)
            {
                Console.WriteLine($"A {keresett} szám nincs a listában");
            }

            List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett = 16;
            bool megtalalva = false;
            int i = 0;

            while (i < szamok.Count)
            {
                if (szamok[i] == keresett)
                {
                    Console.WriteLine($"A keresett szám: ({keresett}) megtalálva a(z) {i}. indexen");
                    megtalalva = true;
                    break;
                }
                i++;
            }
            if (!megtalalva)
            {
                Console.WriteLine($"A {keresett} szám nincs a listában");
            }
            List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett = 16;
            bool megtalalva = false;
            int i = 0;

            if (szamok.Count > 0)
            {
                do
                {
                    if (szamok[i] == keresett)
                    {
                        Console.WriteLine($"A keresett szám: ({keresett}) megtalálva a(z) {i}. indexen");
                        megtalalva = true;
                        break;
                    }
                    i++;
                } while (i < szamok.Count);
            }
            if (!megtalalva)
            {
                Console.WriteLine($"A {keresett} szám nincs a listában");
            }

            List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett = 16;

            if (szamok.Contains(keresett))
            {
                Console.WriteLine($"A keresett szám ({keresett}) megtalálva a listában");
            }
            else
            {
                Console.WriteLine($"A {keresett} szám nincs a listában");
            }
            List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett = 16;
            int index = szamok.IndexOf(keresett);

            if (index != -1)
            {
                Console.WriteLine($"A keresett szám: ({keresett}) megtalálva a(z) {index}. indexen");
            }
            else
            {
                Console.WriteLine($"A {keresett} szám nincs a listában");
            }
            */
            List<int> szamok = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> parosszamok = new List<int>();
            foreach (int i in szamok)
            {
                if (i % 2 == 0)
                {
                    parosszamok.Add(i);
                }
            }
            Console.WriteLine("2-vel osztható számok:" + string.Join(",", parosszamok));


            
            Console.WriteLine("Adj meg  egy számot (1-7):");
            int nap = int.Parse(Console.ReadLine());
            switch (nap)
            {
                case 1:
                    Console.WriteLine("Hétfő");
                    break;
                case 2:
                    Console.WriteLine("Kedd");
                    break;
                case 3:
                    Console.WriteLine("Szerda");
                    break;
                case 4:
                    Console.WriteLine("Csütörtök");
                    break;
                case 5:
                    Console.WriteLine("Péntek");
                    break;
                case 6:
                    Console.WriteLine("Szombat");
                    break;
                case 7:
                    Console.WriteLine("Vasárnap");
                    break;
            
            }
        }


    }
}


