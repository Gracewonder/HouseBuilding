using System;
using System.Collections.Generic;
using System.Text;

namespace HouseProject
{
    public class Window:IPart
    {
        public List<string> windows;

        void IPart.PartOfHouse()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Окно");
            Console.ResetColor();
        }
    }
}
