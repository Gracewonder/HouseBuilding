using System;
using System.Collections.Generic;
using System.Text;

namespace HouseProject
{
    public class Roof:IPart
    {
        public string roof;
        void IPart.PartOfHouse()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Крыша");
            Console.ResetColor();
        }
    }
}
