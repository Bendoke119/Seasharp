using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fela3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] szamok = new int[5];

            szamok[0] = 10;
            szamok[1] = 20;

            int[] szamok2 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(szamok2[1]);
            Console.WriteLine(string .Join(", ", szamok2));
            Console.WriteLine(szamok.GetType());

            List<int> szamok3 = new List<int>();

            szamok3.Add(10);
            szamok3.Add(20);

            List<int> szamok4 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(szamok4[0]);
            Console.WriteLine(string .Join(", ", szamok4));
            Console.WriteLine(szamok4.GetType());*/

            int[] szamok5 = { 1, 12, 3, 4, 5, 6 };
            int max1 = szamok5.Max();
            int max2 = szamok5[0];

            foreach (int szam in szamok5)
            {
                if (szam > max2)
                {
                    max2 = szam;
                }
            }
            Console.WriteLine(max1);
            Console.WriteLine(max2);

            int[] szamok6 = { 1, 12, 3, 4, 5, 6 };
            int sum1 = szamok6.Sum();
            int sum2 = 0;

            foreach (int szam in szamok6)
            {
                sum2 += szam;
            }
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
        }
    }
}
