using System;
namespace Factorial
{
    class Factorial
    {
        public Factorial()
        {
            Console.WriteLine("对象已创建！");
        }

        private int length;
        public void setLength(int l)
        {
            length = l;
        }
        public int getLength()
        {
            return length;
        }

        ~Factorial()
        {
            Console.WriteLine("对象已删除");
        }

        //public static void Main(string[] args)
        //{
        //    Factorial fa = new Factorial();
        //    fa.setLength(16);
        //    Console.WriteLine("对象的长度: " + fa.getLength())
        //}
    }
}