using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : oLine
    {
        public Snake(Point tail,        int lenght,     Direction direction)
        //          точка хваоста,      длина змейки,   направление
        {
            pList = new List<Point>();      //список точек

            for(int i =0; i < lenght; i++)
            {
                Point p = new Point(tail);  //создание точки подобной точке хвоста
                p.Move(i, direction);       //определение координаты следующей точки змейки на основании направления 'direction'
                pList.Add(p);               //добавление точки в список
            }
        }
    }
}
