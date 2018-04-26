using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class GorizontalLine
    {
        List<Point> pList = new List<Point>();

        public GorizontalLine(int x1, int x2, int y, char sym)
        {
            for (int i = x1; i<=x2; i++)
            {
                pList.Add(new Point(i, y, sym));
            }


        }

        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
