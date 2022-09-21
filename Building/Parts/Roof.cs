using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Parts
{
    internal class Roof : IPart
    {
        public static void printRoof(int size) 
        {
            for (int i = 0; i <= size; i++) 
            {
                Console.WriteLine(); 

                for (int k = size; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
            }
        }
    }
}
