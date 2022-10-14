using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
             
            while (i <5)
            {  
                while (j-1 <i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                j = 0;
                i++;
    
            }


            Console.WriteLine();
            int p = 0;
            int k = 0;

            do
            {
                do
                {
                    Console.Write("*");
                    p++;
                }
                while (p -1< k);
                Console.WriteLine();
                p = 0;
                k++;
            }
            while (k < 5);
        }
    }
}
