using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounting
{
    public class CaloriesRepository
    {
        public string[] GetCaloriesInput()
        {
            string[] lines = File.ReadAllLines("../../../../../libs/input.txt");
            return lines;
        }
        
    }
}
