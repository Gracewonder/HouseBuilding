using System;
using System.Collections.Generic;
using System.Text;

namespace HouseProject.BuildingTeam
{
    public class Team
    {
        public Worker worker = new Worker();
        public TeamLeader teamLeader = new TeamLeader();

        public Team()
        {
           teamLeader.name= "Бригадир";
           worker.name= "Рабочий";
        }
    }
}
