using System;
using System.Collections.Generic;
using System.Text;

namespace HouseProject.HouseParts
{
    public class House
    {
        public Basement baseMent = new Basement();

        public List<Wall> walls;

        public List<Window> windows;

        public Roof rOOF = new Roof();

        public House() { }
    }
}
