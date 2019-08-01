using System;
using System.Collections.Generic;
using System.Linq;

namespace technical_task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> List1 = new List<int>() { 1, 2, 2, 3 };
            List<int> List2 = new List<int>() { 11, 3, 1, 5, -9, 11 };

            ListResult(List1, List2);
            Console.WriteLine();
        }

        static void ListResult(List<int> L1, List<int> L2)
        {
            var resultList = L1.Concat(L2);
            resultList = resultList.OrderBy(i => i).ToList();
            foreach (int i in resultList.Distinct())
            {
                Console.Write(" " + i + " ");
            }
        }

    }
}
