using System;
namespace PolymorphismEasy
{
    public class FunctionOverload
    {
        public void add(string a,string b) {
            result = a + " " + b;
            Console.WriteLine(result);
        }
        public void add (int a,int b)
        {
            result1 = a + b;
            Console.WriteLine(result1);
        }

        private string result;
        private int result1;
    }


}
