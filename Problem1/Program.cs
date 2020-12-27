using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Point3D(10, 10,10));

            bool xparsed= false, yparsed = false,  zparsed = false;

            Point3D P1 = new Point3D();
            Point3D P2 = new Point3D();

            for(int i=0;i<2;i++)
            {
                int _X, _Y, _Z;
                do
                {
                    xparsed = int.TryParse(Console.ReadLine(), out _X);

                } while (!xparsed);

                do
                {
                    yparsed = int.TryParse(Console.ReadLine(), out _Y);

                } while (!yparsed);

                do
                {
                    zparsed = int.TryParse(Console.ReadLine(), out _Z);

                } while (!zparsed);
            if(i==0)
                P1 = new Point3D(_X, _Y, _Z);
            else if(i==1)
                P2 = new Point3D(_X, _Y, _Z);
            }

            if (P1 == P2) Console.WriteLine("hello");

            Console.WriteLine(P1.ToString());

            Point3D[] PArr = { new Point3D(1, 1, 3), new Point3D(1, 2, 3), new Point3D(2, 1, 3), new Point3D(3, 1, 3) };

            Array.Sort(PArr, new PointCompare());

            for(int i = 0; i < PArr?.Length; i++)
            {
                Console.WriteLine(PArr[i]);
            }

            Point3D P3 = (Point3D) P1.Clone();
            Console.WriteLine(P3.CompareTo(P1));


        }


    }
}
