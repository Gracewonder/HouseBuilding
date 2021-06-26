using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

using HouseProject.HouseParts;
namespace HouseProject.BuildingTeam
{
    public class TeamLaeder:IWorker
    {
        public string name { get; set; }


        public House CompleetPart(House chekingHouse, out string compleet)
        {
            
            {
                if (!Worker.CheckReport(chekingHouse.baseMent.title))
                {
                    compleet = chekingHouse.baseMent.title;
                }
                else if (!Worker.CheckReport(chekingHouse.walls.title))
                {
                    compleet = chekingHouse.walls.title;
                }
                else if (!Worker.CheckReport(chekingHouse.windows.title))
                {
                    compleet = chekingHouse.windows.title;
                }
                else if (!Worker.CheckReport(chekingHouse.rOOF.title))
                {
                    compleet = chekingHouse.rOOF.title;
                }
                else compleet = null;
            }

            return chekingHouse;
        }
        public void PrintReport(House hs)
        {
            Console.WriteLine($"{hs.baseMent.title} построен");
            Console.WriteLine($"{hs.walls.title} построены");
            Console.WriteLine($"{hs.windows.title} построены");
            Console.WriteLine($"{hs.rOOF.title} построена");
        }

public static void PrintMSG(string str)
        {
            Console.WriteLine(str);
        }

 /*       public string PrintReport(int count)
        {
            string message;
            switch (count)
            {
                case 1:
                    message = "построен фундамент";
                    break;
                case 2:
                    message = "построен фундамет и одна стена";
                    break;
                case 3:
                    message = "построен фундамент и две стены";
                    break;
                case 4:
                    message = "построен фундамент и три стены";
                    break;
                case 5:
                    message = "построе фкндамент и стены";
                    break;
                case 6:
                    message = "построено: фундамент, стены и одно окно";
                    break;
                case 7:
                    message = "построено: фундамент, стены и два окна";
                    break;
                case 8:
                    message = "построено: фундамент, стены и три окна";
                    break;
                case 9:
                    message = "построено: фундамент, стены и окна";
                    break;
                case 10:
                    message = "Дом построен полностью";
                    break;
                default:
                    message = "неудалось проверить готовность постройки";
                    break;
            }
            return message;
 */
        
        
    }
}
