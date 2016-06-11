using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(exR2(6));
            Console.ReadKey();
        }
        public static string exR2(int n)
        {
            if (n < 0) return "";
            return exR2(n - 3) + n + exR2(n - 2) + n;
        }
    }
}
