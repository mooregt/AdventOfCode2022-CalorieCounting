using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var caloriesRepo = new CaloriesRepository();
            var caloriesManager = new CaloriesManager();

            string[] values = caloriesRepo.GetCaloriesInput();
            List<int> caloriesSums = caloriesManager.CalculateCaloriesSums(values);
            foreach (int line in caloriesSums)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
