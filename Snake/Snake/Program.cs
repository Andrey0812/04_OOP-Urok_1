using System;
using System.Threading;

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
            GorizontalLine g1Line = new GorizontalLine(0, 158, 0,'-');  //Верхняя горизонтальная линия
            VerticalLine v1Line = new VerticalLine(0, 0, 49, '|');      //Левая вертикальная линия
            GorizontalLine g2Line = new GorizontalLine(0, 158, 49, '-');//Нижняя горизонтальная линия
            VerticalLine v2Line = new VerticalLine(158, 0, 49, '|');    //Правая вертикальная линия

            //рисуем созданные линии
            g1Line.Draw();
            v1Line.Draw();
            g2Line.Draw();
            v2Line.Draw();

            Console.CursorVisible = false; //делаем  курсор невидимым

            //рисуем точку
            Point l = new Point(40,5, '*');  //начальная позиция змейки
            Snake snake = new Snake(l, 4, Direction.DOWN); //создание змейки с начальной точной l длиной 4единицы вправо от начальной точки
            snake.Draw();   //рисуем змейку
            
            while(true) //бесконечный цикл
            {
                if (Console.KeyAvailable)   //если клавиша нажата после последнего прохождения цикла
                {
                    ConsoleKeyInfo key = Console.ReadKey(); //переменная key хранит нажатую клавишу
                    snake.HandleKey(key.Key);   //обработка методом HandleKey нажатой клавиши
                }
                Thread.Sleep(100);      //задержка на 100 милисекунд
                snake.Move();           //двигаем змейку
            }
        }
    }
}