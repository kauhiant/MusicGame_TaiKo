using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGame
{
    class Point2D
    {
        public float X;
        public float Y;

        public Point2D(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public bool inXRange(int left , int right)
        {
            if (X >= left && X <= right)
                return true;
            return false;
        }
    }
}
