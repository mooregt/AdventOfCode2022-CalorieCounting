using System.IO;

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
