using System;
using HouseProject.BuildingTeam;

namespace HouseProject.HouseParts
{
    class Program
    {
        static void Main(string[] args)
        {
            Tools.Beginning();
            Team team = new Team();
            House houseOne = new House();
            Console.WriteLine($"{team.teamLeader.name} и {team.worker.name} готовы к работе");
            string select;
            string message;
            do { 
                Console.WriteLine($"Выберите команду: 1 - строить; 2 - Посмотреть отчёт; 3 - закончить работу");
                select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        if (houseOne.baseMent.amount == 1 && houseOne.walls.amount == 4 && houseOne.windows.amount == 4 && houseOne.rOOF.amount ==1)
                        {
                            message = "Дом построен";
                            TeamLeader.Printmsg(message);
                        }
                        else
                        {
                            Worker.BuildingPatrs(houseOne, team.worker);
                        }
                        break;
                    case "2":
                        TeamLeader.PrintReport(houseOne);
                        break;
                    default:
                        Console.WriteLine("Команда неверна");
                        break;
                }
            }while (select != "3") ;


        }
    }
}
