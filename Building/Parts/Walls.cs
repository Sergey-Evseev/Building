using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Parts
{
    internal class Walls : IPart
    {
        public void create(House house) {
            house.walls.Add(new Walls());
        }

        public string walls()
        {
            return "|                |\n|                |\n|________________|";
        }
    }
}
