using Building.Parts;
using Building.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    internal class House 
    {
        public Basement basement;
        public List <Walls> walls;
        public List<Window> window;
        public Door door;
        public Roof roof;
        
        
        public void drawHouse()
            {
                Roof.printRoof(8);
                Console.WriteLine(Window.window());
                Console.WriteLine(Door.door());
                Console.WriteLine(Basement.basement());
            }

            public string house()
            {
                return "Building finished";
            }        

    }
}
