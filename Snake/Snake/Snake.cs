using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : oLine //наследование класса ЛИНИЙ
    {
        Direction direction;    //класс храниет данные о направлении движения

        public Snake(Point tail,        int lenght,     Direction _direction)
        //          точка хваоста,      длина змейки,   направление
        {
            direction = _direction;
            pList = new List<Point>();      //список точек

            for(int i =0; i < lenght; i++)
            {
                Point p = new Point(tail);  //создание точки подобной точке хвоста
                p.Move(i, direction);       //определение координаты следующей точки змейки на основании направления 'direction'
                pList.Add(p);               //добавление точки в список
            }
        }

        //движение змейки
        internal void Move()    
        {
            Point tail = pList.First();     //точка tail (хвост) - это первая точка списка
            pList.Remove(tail);             //удаляем из списка "хвостовую" точку
            Point head = GetNextPoint();    //создаём новую (следующую за последней точкой предыдущей змейки, в соответствии с направлением) головную точку
            pList.Add(head);                //добавляем головную точку в список змейки

            tail.Clear();   //удаляем старый хвост
            head.Draw();    //рисуем новую голову
        }

        //метод постройки новой головы змейки. возвращаемый тип - точка
        private Point GetNextPoint()
        {
            Point head = pList.Last();          //голова - последний элемент списка точек змейки
            Point nextPoint = new Point(head);  //создаём новую голову на основании старой,...
            nextPoint.Move(1, direction);       //...сдвигая её на единицу в зависимости от направления direction
            return nextPoint;                   //возвращаем новую голову
        }
    }
}
