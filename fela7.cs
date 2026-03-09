using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fela5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mappaUtvonal = @"C:\Users\info\Desktop\Bendőmendő\okosssag";
            string fajlNev = "elso.txt";
            string teljesUtvonal = Path.Combine(mappaUtvonal, fajlNev);

            Directory.CreateDirectory(mappaUtvonal);

            Console.WriteLine("Írj be sorokat (vége: 'vege'):");
            using (StreamWriter sw = new StreamWriter(teljesUtvonal))
            {
                string sor;
                while ((sor = Console.ReadLine()) != "vege")
{
                    sw.WriteLine(sor);
                }
            }
        }
    }
}
