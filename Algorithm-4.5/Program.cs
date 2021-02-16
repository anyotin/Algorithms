using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace algorithm
{
    class Program
    {
        private static long ans = 0;

        private static int N;

        private static List<string> _357 = new List<string>() {"3", "5", "7"};

        private static List<string> test = new List<string>();

        static void check357(string num)
        {
            Console.WriteLine(num);
            if (int.Parse(num) > N)
            {
                return;
            }

            if (num.IndexOf('7') > -1 && num.IndexOf('5') > -1 && num.IndexOf('3') > -1)
            {
                test.Add(num);
                ans++;
            }

            foreach (var _ in _357)
            {
                var tmp = num + _;
                check357(tmp);
            }
        }

        static int[] Read() => Console.ReadLine().Split().Select(int.Parse).ToArray();

        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            
            check357("3");
            check357("5");
            check357("7");
            
            // 冗長すぎ。
            // List<string> list = new List<string>{"3","5","7"};
            // List<int> allList = new List<int>();
            // int countnum = 0;
            //
            // for (int i = 0; i < N; i++)
            // {
            //     int cnt = i.ToString().Length;
            //     int subcnt = 0;
            //     if (i.ToString().Contains(list[0]) && i.ToString().Contains(list[1]) && i.ToString().Contains(list[2]))
            //     {
            //         for (int j = 0; j < cnt; j++)
            //         {
            //             if (i.ToString().Substring(j, 1).Contains(list[0]) ||
            //                 i.ToString().Substring(j, 1).Contains(list[1]) ||
            //                 i.ToString().Substring(j, 1).Contains(list[2]))
            //             {
            //                 subcnt++;
            //             }
            //         }
            //
            //         if (subcnt == cnt)
            //         {
            //             allList.Add(i);
            //             countnum++;
            //         }
            //     }
            // }
        }
    }
}