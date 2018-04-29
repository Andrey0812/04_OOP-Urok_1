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
            //Установить размер буферной области экрана
            Console.SetBufferSize(160,50);
            //устанавливаем размер окна
            Console.SetWindowSize(160, 50);
            
            //создаём объекты - линия горизонтальная и линия вертикальная
            GorizontalLine g1Line = new GorizontalLine(0, 158, 0,'+');  //Верхняя горизонтальная линия
            VerticalLine v1Line = new VerticalLine(0, 0, 49, '+');      //Левая вертикальная линия
            GorizontalLine g2Line = new GorizontalLine(0, 158, 49, '+');//Нижняя горизонтальная линия
            VerticalLine v2Line = new VerticalLine(158, 0, 49, '+');    //Правая вертикальная линия

            //рисуем созданные линии
            g1Line.Draw();
            v1Line.Draw();
            g2Line.Draw();
            v2Line.Draw();

            //рисуем точку
            Point l = new Point(55,36,'*');
            l.Draw();

            //ждём нажатия Enter, что бы консоль не закрывалась сразу после исполнения программы
            Console.ReadLine();
        }
    }
}