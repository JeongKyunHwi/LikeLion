using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Warrior
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public int Strength { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Warrior warrior = new Warrior();
            //Console.Write("이름을 입력 : ");
            //warrior.Name = Console.ReadLine();
            //Console.Write("점수를 입력 : ");
            //warrior.Score = int.Parse(Console.ReadLine());
            //Console.Write("힘 수치를 입력 : ");
            //warrior.Strength = int.Parse(Console.ReadLine());

            //Console.WriteLine($"이름 : {warrior.Name}, 점수: {warrior.Score}, 힘: {warrior.Strength}");

            //int i;

            //try
            //{
            //    Console.Write("정수를 입력 : ");
            //    i = int.Parse(Console.ReadLine());
            //    Console.WriteLine("입력받은 정수: "+i);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("올바른 숫자를 입력하세요!");
            //}
            //List<string> list = new List<string>();
            //list.Add("사과");
            //list.Add("바나나");
            //list.Add("포도");

            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("첫 번째 작업");
            //queue.Enqueue("두 번째 작업");
            //queue.Enqueue("세 번째 작업");

            //Stack<int> stack = new Stack<int>();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //Console.Write("List 출력 : ");
            //foreach (var item in list)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.Write("\n");
            //Console.Write("Queue 출력 : ");
            //while (queue.Count > 0)
            //{
            //    Console.Write(queue.Dequeue()+" ");
            //}
            //Console.Write("\n");
            //Console.Write("Stack 출력 : ");
            //while (stack.Count > 0)
            //{
            //    Console.Write(stack.Pop()+" ");
            //}
            //string s;
            //Console.Write("문자열 입력: ");
            //s = Console.ReadLine();

            //Console.WriteLine(s.ToUpper());
            //Console.WriteLine(s.Replace("C#", "CSharp"));
            //Console.WriteLine(s.Length);

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            var sum = numbers.Sum();

            foreach(var num in evenNumbers)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();
            Console.WriteLine($"합 : {sum}");
           
        }
    }
}
