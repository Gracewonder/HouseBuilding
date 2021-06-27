using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using HouseProject.HouseParts;
namespace HouseProject.BuildingTeam
{
    public class Worker : IWorker
    {
        public string name { get; set; }

        public static House BuildingPatrs( House hs, Worker wr)
        {
            
            if (hs.baseMent.amount<1)
            {
                Console.WriteLine($"{ wr.name} строит фундамент");
                hs.baseMent.amount ++;
                goto Ex;
            }
            else if(hs.baseMent.amount == 1)
            {

                if (hs.walls.amount<4)
                {
                    Console.WriteLine($"{ wr.name} строит стену");
                    hs.walls.amount ++;
                    goto Ex;
                }
                else if (hs.walls.amount == 4)
                {
                    if (hs.windows.amount<4)
                    {
                        Console.WriteLine($"{ wr.name} устанавливает окно");
                        hs.windows.amount ++;
                        goto Ex;
                    }
                    else if (hs.windows.amount == 4)
                    {
                        if (hs.rOOF.amount<1)
                        {
                            Console.WriteLine($"{ wr.name} строит крышу");
                            hs.rOOF.amount ++;
                            goto Ex;
                        }
                    }
                }
            }
            Ex: return hs;
        }
    }   
}
