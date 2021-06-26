using System;
using System.Collections.Generic;
using System.Text;

namespace HouseProject.BuildingTeam
{
    public class Team
    {
        public Worker worker = new Worker();
        public TeamLaeder teamLaeder = new TeamLaeder();

        public Team() { }
        public Team(string teamLeader, string worker)
        {
            this.teamLaeder.name = teamLeader;
            this.worker.name = worker;
        }


    }
}
