using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8 >> 1;
            int b = a >> 2;
            Console.WriteLine($"{ a}, { b}");
        }
    }
}
