using System;
using System.Collections.Generic;
using System.Text;

namespace HouseProject
{
    public class Wall:IPart
    {
        public List<string> walls;
        void IPart.PartOfHouse()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Стена");
            Console.ResetColor();
        }
    }
}
