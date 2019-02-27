using System;
namespace PolymorphiismHard
{
    public class Rectangle:Shape,IDisplayinterface
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * height);
        }

        public void Display()
        {
            Console.WriteLine("I am a Rectangle");
        }
    }
}
