using System;
using System.Collections.Generic;
using System.Text;
using HouseProject.HouseParts;

namespace HouseProject.BuildingTeam
{
    public interface IWorker
    {
        string name { get; set; }

        public House CompleetPart(House chekingHouse, out string str);
    }
}
