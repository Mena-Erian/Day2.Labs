using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Lab1
{
    class point
    {
        public int x { set; get; }
        public int y { set; get; }
        public int z { set; get; }
        public point() { }
        public point(int x)
        {
            this.x = x;
        }
        public point(int x, int y) : this(x)
        {
            //this.x = x;
            this.y = y;
        }
        public point(int x, int y, int z) : this(x, y)
        {
            //this.x = x;
            //this.y = y;
            this.z = z;
        }
        public void displayAll()
        {
            Console.WriteLine($"value of x =  {x} \t , value of y =  {y} \t , value of z = {z}");
        }

        public int CalcDistance(point p1)
        {
            int distance;
            double partx = (int)Math.Pow((x - p1.x), 2);
            distance = (int)Math.Sqrt(partx);
            return distance;
        }

    }
}
