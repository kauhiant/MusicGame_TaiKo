using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MusicGame
{
    class HitBar
    {
        List<HitPoint> hitPoints;
        Graphics mainGraph;

        public HitBar(Graphics targetScene)
        {
            hitPoints = new List<HitPoint>();
            mainGraph = targetScene;
        }

        public void step()
        {
            for(int i = 0; i < hitPoints.Count; ++i)
            {
                hitPoints[i].show();
                hitPoints[i].move();
                if (hitPoints[i].location.X < -50)
                {
                    hitPoints.RemoveAt(i);
                    --i;
                }
            }
        }

        public void addDon()
        {
            hitPoints.Add(new HitPoint(mainGraph ,Const.rightestPointInBar ,Const.midPoingInBar));
        }

        public int hitDon()
        {
            for (int i = 0; i < hitPoints.Count; ++i)
            {
                if (hitPoints[i].location.inXRange(Const.hitPoint, Const.hitRange))
                {
                    hitPoints.RemoveAt(i);
                    return 1;
                }
            }

            return 0;//沒打到//
        }
    }
}
