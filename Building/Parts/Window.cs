using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Parts
{
    internal class Window : IPart
    {
        public void create(House house)
        {
            house.window.Add(new Window());
        }

        public static string window()
        {
            System.Threading.Thread.Sleep(300);
            return "[ ] [ ] [ ] [ ]";            
        }        
    }
}
