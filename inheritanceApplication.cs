using System;

namespace InheritanceApplication
{
    class ReactAngle
    {
        private double length;
        private double width;

        public ReactAngle(double l, double w)
        {
            this.length = l;
            this.width = w;
        }

        public double getArea()
        {
            return length * width;
        }

        public void display()
        {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", getArea());
        }
    }

    class TableTop:ReactAngle
    {
        private double cost;

        public TableTop(double l, double w) : base(l, w)
        {

        }

        public void getCost(ref double cost)
        {
            cost = getArea() * 70;
        }

        public void display()
        {
            base.display();
            this.getCost(ref cost);
            Console.WriteLine("成本: {0}", cost);
        }
    }

    class ExecuteTable
    {
        public static void Main(string[] args)
        {
            TableTop table = new TableTop(16.34,44.2);
            table.display();
            Console.ReadKey();
        }
    }
}