using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Homework
    {
        public int HasExit(int startI, int StartJ, int[,] l)
        {
            int count = 0;
            Stack<Tuple<int, int>> next = new Stack<Tuple<int, int>>();

            if (l[startI, StartJ] == 0)
            {
                next.Push(new Tuple<int, int>(startI, StartJ));
            }
            while (next.Count > 0)
            {
                var current = next.Pop();
                if (current.Item1 < 0 || current.Item1 == l.GetLength(0)) continue;
                if (current.Item2 < 0 || current.Item2 == l.GetLength(1)) continue;

                if (l[current.Item1, current.Item2] == 1) continue;
                if (l[current.Item1, current.Item2] == 2)
                {
                    count++;
                    l[current.Item1, current.Item2] = 1;
                }

                l[current.Item1, current.Item2] = 1;

                next.Push(new Tuple<int, int>(current.Item1 - 1, current.Item2));
                next.Push(new Tuple<int, int>(current.Item1 + 1, current.Item2));
                next.Push(new Tuple<int, int>(current.Item1, current.Item2 - 1));
                next.Push(new Tuple<int, int>(current.Item1, current.Item2 + 1));
            }
            return count;
        }
    }
}
