using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MusicGame
{
    class HitPoint
    {
        public Point2D location;
        public Image img;
        private Graphics mainGraph;

        public HitPoint(Graphics targetScene,int X, int Y)
        {
            mainGraph = targetScene;
            location = new Point2D(X, Y);
            //init img at subClass
            img = new Bitmap(@"./don.png");
        }

        public void show()
        {
            mainGraph.DrawImage(img, location.X, location.Y);
        }

        public void move()
        {
            location.X -= 10;
        }
    }
}
