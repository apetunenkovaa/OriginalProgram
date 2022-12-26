using System;
using System.Collections.Generic;
using System.Text;

namespace Refactor
{
    class Class1
    {
        public static string txt;
        public static void remov(int k)
        {
            txt = txt.Remove(k);
            Console.WriteLine($"Измененная строка: {txt}");
        }
    }
}
