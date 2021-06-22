using System;
using System.Collections.Generic;
using System.Text;

namespace HouseProject
{
    public class Basement:IPart
    {
        public string basement{ get; set; }
        void IPart.PartOfHouse()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Фундамент");
            Console.ResetColor();
        }
    }
    
}
