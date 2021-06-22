using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HouseProject
{
    public class FileWR
    {
        public void ReadF(out int count)
        {


            var path = @"F:\Corwin\Documents\IT-Step\Homework\Csharp\HouseBuilding\HousePR.txt";
            var input_file = new StreamReader(path);
            string line;
            count = 0;
            while ((line = input_file.ReadLine()) != null)
            {
                count++;              
            }
            input_file.Close();  
        }
    }
}
