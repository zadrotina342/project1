using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Kvit kvit = new Kvit();

            kvit.Nom = 26;
            kvit.Data = "23.09.2021";
            kvit.Sum = 225;

            Console.WriteLine($"{kvit.Nom}  {kvit.Data}  {kvit.Sum}");

            Kvit kvit1 = new Kvit();
            kvit1.Nom = 26;
            kvit1.Data = "24.09.2021";
            kvit1.Sum = 200;

            Console.WriteLine($"{kvit1.Nom}  {kvit1.Data}  {kvit1.Sum}");

            Console.ReadKey();
        }
    }
}
