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
        public List <Walls> walls; //список стен
        public List<Window> window; //список окон
        public Door door;
        public Roof roof;
        
        
        public void drawHouse(TeamLeader leader)
            {
            if (leader.progressList.Count == 11)
                {
                Roof.printRoof(8);
                Console.WriteLine(Walls.walls());
                Console.WriteLine(Window.window());
                Console.WriteLine(Walls.walls());
                Console.WriteLine(Door.door());
                Console.WriteLine(Basement.basement());
                Console.WriteLine("\nBuilding finished!");
            }
            else Console.WriteLine("The house is not built yet");
        } 
    }
}
