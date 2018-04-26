using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    //класс для рисования линий из заданного символа
    class GorizontalLine
    {
        //создаём список точек
        List<Point> pList = new List<Point>();

        //создаём объект "горизонтальная линия" с исходными данными 
        // х1 - начало линии x2- конец линии, y - на какой строке линия, sym - символ, из которого строим линию
        public GorizontalLine(int x1, int x2, int y, char sym)
        {
            //цикл для создания всех точек линии (от левого края х1 до правого края х2)
            for (int i = x1; i<=x2; i++)
            {
                //создаём новую точку в список
                pList.Add(new Point(i, y, sym));
            }
        }

        //рисуем все точки
        public void Draw()
        {
            //цикл, проходящий по всем элементам листа pList
            foreach(Point p in pList)
            {
                //рисуем точку (символ то есть)
                p.Draw();
            }
        }
    }
}
