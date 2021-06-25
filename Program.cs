using System;
using HouseProject.BuildingTeam;

namespace HouseProject.HouseParts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Строительство дома");
            Console.WriteLine("------------------");

            House houseOne = new House();
            House houeTemp = new House();
            Team team = new Team("Бригадир","Рабочий");
            Console.WriteLine("Бригада готова к работе");
            string select;
            do
            {
                Console.WriteLine("Веберите команду: 1 - строить, 2 - посмотреть отчёт, 3 - закончить работу");
                select = Console.ReadLine();
                switch(select)
                {
                    case "1":
                        team.worker.ChekReport()
                        break;
                    case "2":
                        break;
                    default:
                        break;
                }

            } while (select != "3");
        }
    }
}
