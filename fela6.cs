using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0216feldaaata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<object>> automata = new List<List<object>>();
            string file1 = @"C:\Users\info\Desktop\Bendőmendő\2 23 5 100 csoki.txt";

            foreach (string sor in File.ReadLines(file1))
            {
                string[] darabok = sor.Trim().Split(' ');
                List<object> adatsor = new List<object>();
                adatsor.Add(int.Parse(darabok[0]));
                adatsor.Add(int.Parse(darabok[1]));
                adatsor.Add(int.Parse(darabok[2]));
                adatsor.Add(int.Parse(darabok[3]));
                adatsor.Add(darabok[4]);
                automata.Add(adatsor);
            }
            foreach (var sor in automata)
            {
                Console.WriteLine(string.Join(",", sor));
            }

            Console.WriteLine($" Az automatában {automata.Count} féle termék van!");

            for (int i = 0; i < automata.Count; i++)
            {
                Console.WriteLine(automata[i][4]);
            }
            int db = 0;
            for (int i1 = 0; i1 < automata.Count; i1++)
            {
                db = db + (int)automata[i1][0];
            }
            Console.WriteLine(db);
            Console.WriteLine($"Az automatában {automata.Count} féle termék van!");

            for (int i = 0;i < automata.Count; i++)
            {
                Console.WriteLine(automata[i][4]);
            }

            int db1 = 0;

            for (int i1 = 0;i1 < automata.Count; i1++)
            {
                db1 = db1 + (int)automata[i1][0];
            }
            Console.WriteLine(db1);

            int min1 = (int)automata[0][0];

            for(int i2 = 0;i2<automata.Count; i2++)
            {
                if(min1 < (int)automata[i2][0])
                { min1 = (int)automata[i2][0];
                }
            }
            Console.WriteLine(min1);
        }
    }
}