using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._01
{
    class NameCard
    {

        public int Age
        {
           get; set;
        }

        public string Name
        { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {

            NameCard Mycard = new NameCard();

            Mycard.Name = "상현";
            Mycard.Age = 24;

            Console.WriteLine($"나이 : {Mycard.Age}");
            Console.WriteLine($"이름 : {Mycard.Name}");
        }
    }
}
