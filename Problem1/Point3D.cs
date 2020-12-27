using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    class Point3D
    {
        int x, y, z;

        public Point3D(int _X, int _Y, int _Z)
        {
            x = _X;
            y = _Y;
            z = _Z;
        }

        public Point3D(int _X, int _Y) : this(_X,_Y,0)
        {
            ;
        }

        public Point3D(int _X) : this(_X,0, 0)
        {
            ;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }
    }
}
