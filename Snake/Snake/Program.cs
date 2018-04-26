using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //изменение ширины окна консоли на значение 100 (столбцов)
            Console.WindowWidth = 100;
            //изменение высоты окна консоли на значение 50 (строк)
            Console.WindowHeight = 50;

            //создаём объекты - линия горизонтальная и линия вертикальная
            GorizontalLine pLine = new GorizontalLine(10, 20, 10,'-');
            VerticalLine oLine = new VerticalLine(15, 10, 20, '|');

            //рисуем линии
            pLine.Draw();
            oLine.Draw();
            pLine.Draw();

            //ждём нажатия Enter, что бы консоль не закрывалась сразу после исполнения программы
            Console.ReadLine();
        }
    }
}