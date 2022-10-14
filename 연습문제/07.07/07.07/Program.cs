using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._07
{
    class Program
    {
        public static string s = "";
        public static string t = "";
        static void Main(string[] args)
        {
            Console.WriteLine("나이를 입력하세요");
            s = Console.ReadLine();

            Console.WriteLine("신분을 입력하세요 (학생, 일반)");
            t = Console.ReadLine();

            string[] z = new string[] { s, t };

            int a = Convert.ToInt32(s);
            if (0<a && a< 18)
            {
                switch (t)
                {
                    case "학생":
                        Console.WriteLine("0.2");
                        break;
                    case "일반":
                        Console.WriteLine("0.1");
                        break;
                    default:
                        Console.WriteLine("0");
                        break;
                }
            }
            else if (a > 18)
            {
                switch (t)
                {
                    case "학생":
                        Console.WriteLine("0.1");
                        break;
                    case "일반":
                        Console.WriteLine("0.05");
                        break;
                    default:
                        Console.WriteLine("0");
                        break;
                }
            }
           

        }
    }
}
