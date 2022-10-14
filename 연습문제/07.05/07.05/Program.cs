using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._05
{
    struct ACSetting
    {
        public double currentInCelsius;
        public double target;

        public double GetFarenheit()
        {
            target = currentInCelsius * 1.8 + 32;
            return target;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;
            Console.WriteLine($"{acs.GetFarenheit()}");

            acs.target = 25;
            Console.WriteLine($"{acs.target}");
        }
    }
}
