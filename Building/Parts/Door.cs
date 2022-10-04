using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Parts
{
    internal class Door : IPart
    {
        public void create(House house) //создание двери в конструкторе
        {
            house.door = new Door();
        }

        public static string door()
        {
            return "|| / |_________|\n|| / |_________|";
        }        
    }
}
