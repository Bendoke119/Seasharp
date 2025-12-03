using System;
using System.Collections.Generic;
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
            }*/
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Hajrá ZTE");
            }
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Fujpest");
            }

        }
    }
}
