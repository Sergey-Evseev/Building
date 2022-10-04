using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Team
{
    internal class Basement : IPart
    {
        public void create(House house)
        {
            house.basement = new Basement();
        }

        public static string basement() {
            System.Threading.Thread.Sleep(300);
            return "===============";              
        }        
    }
}
