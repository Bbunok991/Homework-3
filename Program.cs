using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Homework homework = new Homework();
            int[,] labirynth1 = new int[,]
            {
                {1, 1, 1, 1, 1, 1, 1 },
                {1, 0, 0, 0, 0, 0, 1 },
                {1, 0, 1, 1, 1, 0, 1 },
                {0, 0, 0, 0, 1, 0, 0 },
                {1, 1, 0, 0, 1, 1, 1 },
                {1, 1, 1, 0, 1, 1, 1 },
                {1, 1, 1, 0, 1, 1, 1 }
            };
            Console.WriteLine("Количество выходов: " + homework.HasExit(3, 0, labirynth1)); Console.ReadKey();
        }
    }
}
