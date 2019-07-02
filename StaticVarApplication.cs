using System;

namespace StaticVarApplication
{
    class StaticVar
    {
        public static int num;

        public void count()
        {
            num++;
        }

        public int getCount()
        {
            return num;
        }
    }

    class StaticTester
    {
        //public static void Main(string[] args)
        //{
        //    StaticVar counter1 = new StaticVar();
        //    StaticVar counter2 = new StaticVar();
        //    counter1.count();
        //    counter1.count();
        //    counter1.count();
        //    counter2.count();
        //    counter2.count();
        //    counter2.count();
        //    Console.WriteLine("counter1.Num: " + counter1.getCount());
        //    Console.WriteLine("counter2.Num: " + counter2.getCount());
        //    Console.ReadKey();
        //}

    }
}