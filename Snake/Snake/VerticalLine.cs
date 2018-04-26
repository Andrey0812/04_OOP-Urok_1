using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        //создаём пустой список точек
        List<Point> pList = new List<Point>();

        //создаём объект - вертикальную линию
        public VerticalLine(int x, int y1, int y2, char sym)
        {
            for(int i = y1; i<=y2; i++)
            {
                pList.Add(new Point(x, i, sym));
            }
        }

        //рисуем все элементы линии
        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
