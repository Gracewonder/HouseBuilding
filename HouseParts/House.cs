using System;
using System.Collections.Generic;
using System.Text;

namespace HouseProject.HouseParts
{
    public class House
    {
        public Basement baseMent = new Basement();

        public Wall walls=new Wall();

        public Window windows=new Window();

        public Roof rOOF = new Roof();

        public House() { }
        public House(Basement basement,Wall wall,Window window,Roof roof)
        { }
    }
}
