using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidht;   //переменна будет хранить принятые ширину игрового поля,
        int mapHight;   //высоту игрового поля
        char sym;       //и символ еды

        Random random = new Random();

        //метод передающий исходные параметры для создания еды
        public FoodCreator(int mapWidht, int mapHight, char sym)
        {
            this.mapWidht = mapWidht;   //this - даёт обращение к созданным ранее в этом класе переменным
            this.mapHight = mapHight;
            this.sym = sym;
        }

        //создание еды
        public Point CreateFood()
        {
            int x = random.Next(2, mapWidht - 2);   //2 - из-за ограничивающих игровое поле линий
            int y = random.Next(2, mapHight - 2);   
            return new Point(x,y,sym);
        }

    }
}
