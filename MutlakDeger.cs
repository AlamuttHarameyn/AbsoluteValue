using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._14._1_IfElseYapisi
{
    class MutlakDeger
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine($"|{n}| = {n * -1}");
            }
            else
            {
                Console.WriteLine($"|{n}| = {n}");
            }
            Console.ReadKey();
        }
    }
}
