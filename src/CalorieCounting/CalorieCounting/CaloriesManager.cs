using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounting
{
    public class CaloriesManager
    {
        public CaloriesManager() { }

        public List<int> CalculateCaloriesSums(string[] values)
        {
            var caloriesSums = new List<int>();
            int sum = 0;
            foreach (string value in values)
            {
                if (value != string.Empty)
                {
                    sum = sum + int.Parse(value);
                }
                else
                {
                    caloriesSums.Add(sum);
                    sum = 0;
                }
            }
            return caloriesSums;
        }
    }
}
