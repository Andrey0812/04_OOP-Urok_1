using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        private int x;
        private int y;
        private char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        //создание новой точки на основе уже имеющейся точки
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        //определение того, какая координата будет у НОВОЙ точки в зависимости от направления относительно УЖЕ ИМЕЮЩЕЙСЯ точки
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT) x = x + offset;
            else if (direction == Direction.LEFT) x = x - offset;
            else if (direction == Direction.UP) y = y - offset;
            else if (direction == Direction.DOWN) y = y + offset;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
