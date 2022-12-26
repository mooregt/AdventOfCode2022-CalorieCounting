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
            string[] lines = File.ReadAllLines("../../../../../libs/input.txt");
            Console.WriteLine(lines[0]);
            Console.ReadLine();
        }
    }
}
