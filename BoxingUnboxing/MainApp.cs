using System;

namespace BoxingUnboxing
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 123;
            object b = (object)a; // a�� ��� ���� �ڽ��ؼ� ���� ����
            int c = (int)b; // b�� ��� ���� ��ڽ��ؼ� ���ÿ� ����

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}