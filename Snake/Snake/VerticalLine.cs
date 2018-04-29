using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : oLine  //наследование свойств из oLine, т.е. вертикальная линия - частный случай линии. 
    {
        //создаём объект - вертикальную линию
        public VerticalLine(int x, int y1, int y2, char sym)
        {
            for(int i = y1; i<=y2; i++)
            {
                pList.Add(new Point(x, i, sym));
            }
        }
    }
}
