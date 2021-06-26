using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using HouseProject.HouseParts;
namespace HouseProject.BuildingTeam
{
    public class Worker:IWorker
    {
        public string name { get; set; }
       
        public static bool CheckReport(string str)

        {
            if (str == null)
            {
                return true;
            }
            else return false;
        }

        public House CompleetPart(House chekingHouse, out string compleet)
        {

            {
                if (CheckReport(chekingHouse.baseMent.title))
                {
                    chekingHouse.baseMent.title = "Фундамент";
                    compleet = $"{chekingHouse.baseMent.title} готов";

                }
                else if (CheckReport(chekingHouse.walls.title))
                {
                    chekingHouse.walls.title = "Стены";
                    compleet = $"{chekingHouse.walls.title} готовы";
                }
                else if (CheckReport(chekingHouse.windows.title))
                {
                    chekingHouse.windows.title = "Окна";
                    compleet = $"{chekingHouse.windows.title} готовы";
                }
                else if (CheckReport(chekingHouse.rOOF.title))
                {
                    chekingHouse.rOOF.title = "Крыша";
                    compleet = $"{chekingHouse.rOOF.title} готова";
                }
                else compleet ="Дом построен";
            }

            return chekingHouse;
        }
    }
}
