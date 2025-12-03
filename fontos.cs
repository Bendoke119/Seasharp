using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fela12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("A négyzet kerülete");
            Console.WriteLine("Kérem az A oldalt");
            int a = int.Parse(Console.ReadLine()); //cr == input(py)
            Console.WriteLine("A kerülete:");
            Console.WriteLine(4 * a);
            Console.WriteLine("A területe:");
            Console.WriteLine(a * a);
            Console.WriteLine("A téglalap kerülete és területe");
            Console.WriteLine("Kérem az A oldalt");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérem a B oldalt");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("A kerülete:" + (2 * a + 2 * b)); //A műveletet zárójelben kell megadni!
            double ker = 2 * a + 2 * b; //A double érték képes bizonyos változói egyenletek eltárolására amelyek előhívhatóak
            double ter = a * b;
            Console.WriteLine($"A területe: {ter}"); //A "$" jel segítségével lehet double értékeket berakni a szövegben
            if (ker == ter)
            {
                Console.WriteLine("Egyenlő");
            }
            else if (ker > ter) //else if == elif(py)
            {
                Console.WriteLine("A kerület nagyobb");
            }
            else if (ker < ter)
            {
                Console.WriteLine("A terület nagyobb");
            }
            Random rnd = new Random(); //Egy Random változó amely egyenlő egy új(new) Random értékkel felel meg az import Random(py)-nak

            Console.WriteLine("Tanár diák kocka játék");
            int tanar = rnd.Next(1, 6); //rnd.Next == Random.randint(py)
            Console.WriteLine($"A tanár {tanar}-ost/est dobott.");
            int diak = rnd.Next(1, 6);
            Console.WriteLine($"A diák {diak}-ost/est dobott");
            if (tanar == diak)
            {
                Console.WriteLine("Döntetlen");
            }
            else if (tanar > diak)
            {
                Console.WriteLine("A tanár nyert");
            }
            else if (tanar < diak)
            {
                Console.WriteLine("A diák nyert");
            }
            for (int i = 1; i <= 5; i++) //Olyan mint a while a py-ban
            {
                Console.WriteLine(i);
            }
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Hajrá ZTE");
            }
            for (int i = 1; i <= 3; i++) //Olyan mint a while ciklus (változó, művelet ,hozzá adunk eggyet)
            {
                Console.WriteLine("Fujpest");
            }
            
            string[] nevek = { "Zebulon", "Béci", "Boda" }; //string változó mert szavakat(neveket) tárolunk benne

            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine(nevek[i]); //Az i változó a nevek kiírásáért felel ezért szükséges
            }
            string[] nevek = { "Zebulon", "Béci", "Boda" };

            foreach (string nev in nevek) //Olyan mint a jól ismert for ciklus a python-ból + a "string" előjel itt is és máshol is fontos! 
            {
                Console.WriteLine(nev);
            }
            int i = 0;
            while (i < 5) //A while ciklus ugyanolyan mint a python-os változata
            {
                Console.WriteLine(i);
                i++;
            }
            
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5); //Ugyanazt csinálja mint az előző while-os csak itt a feltételt az új "do" művelet után írjuk.
            
            int[] szamok = { 12, 8, 5, 3, 1 };
            int min = szamok[0];
            for (int i = 1; i < szamok.Length; i++)
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
            }
            Console.WriteLine(min);

            int[] szamok = { 12, 8, 5, 3, 1 };
            int min = szamok[0];

            foreach (int szam in szamok)
            {
                if (szam < min)
                {
                    min = szam;
                }
            }
            int[] szamok = { 12, 8, 5, 3, 1 };
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
            Console.WriteLine("A legkisebb szám: " + min);

            int[] szamok = { 12, 8, 5, 3, 1 , -56 };
            int min = szamok[0]; //A minimumnak nem muszály az pont elsö elemmel egyenlőnek lennie hanem más elemmel is működik
            int i = 1;
            do
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
                i++;
            } while (i < szamok.Length);
            Console.WriteLine("A legkisebb szám: " + min);*/

            int[] szamok = { 12, 8, 5, 3, 1, -56 };

            int min = szamok.Min();
            Console.WriteLine($"A legkisebb szám: {min}"); 

        }
    }
}
