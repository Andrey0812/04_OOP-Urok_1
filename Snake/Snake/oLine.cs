using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class oLine
    {
        //создаём список точек
        //protected - модификатор доступа. Доступ к типу или элементу можно получить только из кода в том же классе или структуре, либо в производном классе.
        protected List<Point> pList = new List<Point>();

        public void Draw()
        {
            //цикл, проходящий по всем элементам листа pList
            foreach (Point p in pList)
            {
                //рисуем точку (символ то есть)
                p.Draw();
            }
        }
    }
}
