using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Parts
{
    internal class Walls : IPart
    {
        public void create(House house) {//метод создания стены в классе
            house.walls.Add(new Walls());//добавление стены в список стен
        }

        public static string walls()
        {
            System.Threading.Thread.Sleep(300);
            return "|             |";
        }
    }
}