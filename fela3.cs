using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fela4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> üvegek = new List<int> { 5, 2, 2, 4, 3, 2, 4, 10, 5, 5, 3, 5, 4, 3, 3 };
            Console.WriteLine(üvegek);
            Console.WriteLine("Mari nénje mennyi lekvárt kér be?");
            string bekeres = Console.ReadLine();
            int szam = int.Parse(bekeres);
            int l = szam;
            if (l > 0 && l < 200)
            {
                Console.WriteLine("Mari néni lekvárja (dl):" + bekeres);
            }
            else
            {
                Console.WriteLine("Ez nem felel meg az értékeknek");
            }

            int max = 0;
            foreach (int i in üvegek)
            {
                if (max < i) 
                {
                    max = i;
                }
            }
            int b = 0;
            foreach (int i in üvegek)
            {
                if (b == max)
                {
                    b= i;
                }
                b++;
            }
            Console.WriteLine(max);
            Console.WriteLine("A nyolcadik " ,b);
            int Sum = üvegek.Sum();
            if (Sum + 1 > l)
            {
                Console.WriteLine("Belefér");
                Console.WriteLine("Ennyi férne bele összesen: " + Sum);
            }
            else
            {
                Console.WriteLine("Nem fér bele");
            }


            
        }
    }
}
