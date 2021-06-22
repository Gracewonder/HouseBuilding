using System;
using System.Collections.Generic;
using System.Text;

namespace HouseProject.BuildingTeam
{
    public class TeamLaeder
    {
        public string PrintRaport(int count)
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
        }
        
    }
}
