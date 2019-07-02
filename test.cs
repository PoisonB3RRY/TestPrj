using System;

namespace ReactAngle
{
    class ReactAngle{

        double length;
        double width;
        public void init(){
            length = 3.3;
            width = 4.4;
        }

        public void display(){
            Console.WriteLine("Length = " + length);
            Console.WriteLine("Width = " + width);
            Console.WriteLine("Area = " + length*width);
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello\tWorld\n\n");
        //    Console.WriteLine(typeof(decimal));
        //    Console.ReadKey();
        //}
    }
}