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
            string[] lines = caloriesRepo.GetCaloriesInput();
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
