using System;
using static System.Console;

namespace Hello
{
    class MainApp{
        static void Main(string[] args){
            if(args.Length == 0){
                WriteLine("���� : Hello.exe<�̸�>");
                return;
            }
            WriteLine("Hello, {0}!", args[0]);
        }
    }
}