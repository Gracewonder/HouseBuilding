using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

using HouseProject.HouseParts;
namespace HouseProject.BuildingTeam
{
    public class TeamLeader:IWorker
    {
        public string name { get; set; }
        public static void PrintReport(House hs)
        {
            Console.WriteLine($"Построено: ");
            Console.WriteLine($"Фундамент - {hs.baseMent.amount};");
            Console.WriteLine($"Стены - {hs.walls.amount};");
            Console.WriteLine($"Окна- {hs.windows.amount};");
            Console.WriteLine($"Крыша - {hs.rOOF.amount};");
        }
        public static void Printmsg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
