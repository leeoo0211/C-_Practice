using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("사각형의 너비를 입력하세요.");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를- 입력하세요.");
            string height = Console.ReadLine();

            int width_ = int.Parse(width);
            int height_ = int.Parse(height);

            var area = width_ * height_;
            Console.WriteLine($"사각형의 넓이는 {area}");




        }
    }
}
