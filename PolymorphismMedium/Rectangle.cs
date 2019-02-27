using System;
namespace PolymorphismMedium
{
    public class Rectangle:Shape
    {
        private int a = 40;
        private int b = 50;
        private int area1;
        public override int area()
        {
            area1 = a * b;
            Console.WriteLine(area1);
            return area1;
        }
    }
}
