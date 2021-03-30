using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNet_HotTechInterviewTasks.LINQ
{
    static class MinMaxInt
    {
        public static void PrintResult(IEnumerable<int> list = null)
        {
            var listOfAnyObjects = list ?? new List<int> { -1, 1, 2, 39, -95, -7, 0 };

            var minMax = listOfAnyObjects.Aggregate(
                new { Min = 0, Max = 0 }, (accumulator, number) =>
                new
                {
                    Min = Math.Min(number, accumulator.Min),
                    Max = number > accumulator.Max ? number : accumulator.Max
                });

            Console.WriteLine($"Min={minMax.Min};Max={minMax.Max}");
        }
    }
}
