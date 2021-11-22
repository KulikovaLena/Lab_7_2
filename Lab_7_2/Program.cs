using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            double S, V;
            GetParam(a, out S, out V);
            Console.WriteLine("S={0}", S);
            Console.WriteLine("V={0}", V);
            Console.ReadKey();
        }
        static void GetParam(int a, out double S, out double V)
        {
            S = 6*a*a;
            V = a*a*a;
        }
    }
}
