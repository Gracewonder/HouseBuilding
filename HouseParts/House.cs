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

        public House()
        { baseMent.amount =0;
            walls.amount = 0;
            windows.amount = 0;
            rOOF.amount = 0;
        }
    }
}
