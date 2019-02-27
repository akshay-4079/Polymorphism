using System;

namespace PolymorphismEasy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The Simplest form of polymorphism is function overloading");
            string a = "Hello";
            string b = "World";
            int c = 1;
            int d = 2;
            FunctionOverload func = new FunctionOverload();
            func.add(a, b);
            func.add(c, d);
        }
    }
}
