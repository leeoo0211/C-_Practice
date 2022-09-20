using System;
using static System.Console;

namespace FloatConversion 
// double, float 사이의 형 변환은 오류가 생길 수 있다. 
//float이나 double은 소수를 2진수로 저장하기에 형 변환 시 10진수로 복원 후, 다시 2진수로 변환하기에 변환 과정에서 수의 변화가 생길 수 있다.
{
    class MainApp
    {
        static void Main(string[] args) 
        {
            float a = 69.6875f;
            WriteLine("a : {0}", a);

            double b = (double)a;
            WriteLine("b : {0}");
            WriteLine("69.6875 == b : {0}", 69.6875 == b);

            float x =0.1f;
            WriteLine("x : {0}", x);

            double y = (double)x;
            WriteLine("y : {0}", y);

            WriteLine("0.1 == y : {0}", 0.1 ==y);
        }
    }
}