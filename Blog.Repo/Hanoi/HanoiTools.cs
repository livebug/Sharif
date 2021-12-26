using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repo.Hanoi
{
    public static class HanoiTools
    {
        public static void Hanoi1(int num,string start,string mid,string end)
        {
            if (num==1)
            {
                Move(num, start, end);
            }
            else
            {
                Hanoi1(num - 1, start, end, mid);
                Move(num,start, end);
                Hanoi1(num - 1, mid, start, end);
            }
        }

        private static void Move(int num, string start, string end)
        {
            Console.WriteLine($"{num},{start} -> {end}");
        }

    }
}
