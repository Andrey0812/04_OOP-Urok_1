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
            
            //список точек
            List<Point> pointList = new List<Point>();
            
            //список символов для точек
            List<char> symList = new List<char>()
            {
                '0',    //символ для первой точки
                '*',    //символ для второй точки
                '+',    //символ для третьей точки
                '?'     //символ для четвёртой точки
            };

            //список координат для точек по оси х
            List<int> XnumList = new List<int>
            {
                10,     //координата х для первой точки
                20,     //координата х для второй точки
                30,     //координата х для третьей точки
                40      //координата х для четвёртой точки
            };

            //список координат для точек по оси у
            List<int> YnumList = new List<int>
            {
                1,      //координата у для первой точки
                2,      //координата у для второй точки
                2,      //координата у для третьей точки
                3       //координата у для четвёртой точки
            };

            //всего строим 4 точки, то есть с индексами 0,1,2,3
            for (int i = 0; i < 4; i++)     
            {
                //добавляем в лист с точками новую точку (первую точку)
                pointList.Add(new Point(XnumList[i], YnumList[i], symList[i])); 
                //рисуем добавленную точку
                pointList[i].Draw();
            }
            
            //ждём нажатия Enter, что бы консоль не закрывалась сразу после исполнения программы
            Console.ReadLine();
        }
    }
}