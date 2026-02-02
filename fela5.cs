using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fela3
{
    internal class Program
    {
        static void szam()
        {
            
            int i = 0;
            while (i < 1)
            {
                Console.WriteLine("Kérek egy számot!");
                string bekeres = Console.ReadLine();
                if (int.TryParse(bekeres, out int szam))
                {
                    Console.WriteLine("Ez a számod: " + szam);
                    i++;
                }
                else
                {
                    Console.WriteLine("Ez nem szám");
                }
            }
        }
        static(double ker, double ter) kor()
        {
            Console.WriteLine("Kérem a kör sugarát!");
            string bekeres_kor = Console.ReadLine();
            int r = int.Parse(bekeres_kor);
            double ker = 2*r*3.14;
            double ter = 2 * (r * r);
            return (ker, ter);

        }
        static void Main(string[] args)
        {
            szam();
            var koradatok = kor();
            Console.WriteLine($"Ez a kör területe: {koradatok.ker}");
            Console.WriteLine($"Ez a kör területe: {koradatok.ter}");

            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            int b;
            int c = 0;
            int a = 10;
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                b = a / c;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("------------------------------------");
            try
            {
                int[] halmaz = { 5, 8, 12, 21, 35 };

                Console.Write("Első szám: ");
                int szam1 = int.Parse(Console.ReadLine());
                Console.Write("Második szám: ");
                int szam2 = int.Parse(Console.ReadLine());

                int osszeadas = szam1 + szam2;

                Console.WriteLine($"A halmaz {osszeadas}. eleme: {halmaz[osszeadas - 1]}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba: " + e.Message);
            }
        }
    }
}
