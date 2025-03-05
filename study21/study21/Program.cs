using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study21
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "Charlie", "Alice", "Bob" };
            //var sortedNames = names.OrderBy(n => n);

            //foreach(var name in sortedNames)
            //{
            //    Console.WriteLine(name);
            //}
            //var firstName = names.First(n => n.StartsWith("A"));
            //Console.WriteLine(firstName);

            //int[] nums = { 5, 3, 8, 1 };

            //var sortedMethod = nums.OrderByDescending(n => n);

            //var sortedQuery = from n in nums orderby n select n;

            //foreach(var i in sortedMethod)
            //{
            //    Console.Write(i);
            //}
            //foreach (var i in sortedQuery)
            //{
            //    Console.Write(i);
            //}
            //string[] words = { "apple", "banana", "cherry" };

            //var length = words.Select(w => w.Length);

            //foreach(var i in length)
            //{
            //    Console.Write(i);
            //}

            //var upperWords = words.Select(w => w.ToUpper());

            //foreach (var i in upperWords)
            //{
            //    Console.Write(i);
            //}

            //int[] data = { 1, 2, 3, 4 };
            //int sum = 0;

            //foreach(var i in data)
            //{
            //    sum += i;

            //}
            //Console.WriteLine(sum);

            //float[] data = { 80, 71, 66 };
            //double avg = data.Average();
            //Console.WriteLine(avg);
            //float max = data.Max();
            //Console.WriteLine(max);
            //float min = data.Min();
            //Console.WriteLine(min);

            //int[] data = { 10, 12, 20, 25, 30 };
            //int target = 22;

            //int nearest = data[0];

            //foreach(var d in data)
            //{
            //    if (Math.Abs(d - target) < Math.Abs(nearest - target)){
            //        nearest = d;
            //    }
            //}

            //Console.WriteLine(nearest);

            //int[] score = { 53, 60, 90, 70, 86 };
            //Array.Sort(score);

            //for (int i = 0; i < score.Length; i++)
            //{
            //    int rank = 1;
            //    for (int j = 0; j < score.Length; j++)
            //    {
            //        if (score[j] > score[i])
            //        {
            //            rank++;
            //        }
            //    }
            //    Console.WriteLine(score[i] + " , " + rank);
            //}

            //int[] data = { 5, 2, 8, 1, 3 };
            //Array.Sort(data);
            //foreach(var d in data)
            //{
            //    Console.WriteLine(d);
            //}

            //int[] data = { 5, 2, 8, 1, 9 };
            //int target = 8;
            //int index = -1;

            //for(int i=0; i < data.Length; i++)
            //{
            //    if (data[i] == target)
            //    {
            //        index = i;
            //        break;
            //    }
            //}
            //Console.WriteLine(index >= 0 ? $"{target} : Found at index {index}" : "Not Found");

            string[] fruits = { "apple", "banana", "blueberry", "cherry", "apricot" };
            var groups = fruits.GroupBy(f => f[0]);

            foreach(var g in groups)
            {
                Console.WriteLine($"Key : {g.Key}");
                foreach(var item in g)
                {
                    Console.WriteLine($"{item}");
                }

            }




        }
    }
}
