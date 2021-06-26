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
            string message;
            House houseOne = new House();
            House houseTwo = new House();
            Team team = new Team("Бригадир","Рабочий");
            Console.WriteLine($"{team.teamLaeder} и {team.worker} готовы работе");
            string select;
            do
            {
                Console.WriteLine("Веберите команду: 1 - строить, 2 - посмотреть отчёт, 3 - закончить работу");
                select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        new TeamLaeder().CompleetPart(houseOne, out string checking);
                        if (checking == null)
                        { message = $"{team.worker.name} строит фундамент";
                            TeamLaeder.PrintMSG(message);
                            new Worker().CompleetPart(houseOne, out string cmplt);
                            TeamLaeder.PrintMSG(cmplt);
                            houseOne.baseMent.title = "Фундамент";
                        }
                        else { message = $"{team.worker.name} строит {checking}";
                            TeamLaeder.PrintMSG(message);
                        }
                        break;
                    case "2":
                        new TeamLaeder().PrintReport(houseOne);
                        break;
                    default:
                        message = "Команда неясна";
                        TeamLaeder.PrintMSG(message);
                        break;
                }

            } while (select != "3");
        }
    }
}
