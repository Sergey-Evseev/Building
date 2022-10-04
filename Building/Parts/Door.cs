using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Parts
{
    internal class Door : IPart
    {
        public void create(House house) //создание двери
        {
            house.door = new Door();
        }

        public static string door()
        {
            System.Threading.Thread.Sleep(300);
            return "|| / |________|\n|| / |________|";
        }        
    }
}
