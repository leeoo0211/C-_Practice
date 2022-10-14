using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._02
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >=0; i--)
            {
                for(int j = i+1; j>0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
