using System;
using static System.Console;

namespace FloatConversion 
// double, float ������ �� ��ȯ�� ������ ���� �� �ִ�. 
//float�̳� double�� �Ҽ��� 2������ �����ϱ⿡ �� ��ȯ �� 10������ ���� ��, �ٽ� 2������ ��ȯ�ϱ⿡ ��ȯ �������� ���� ��ȭ�� ���� �� �ִ�.
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