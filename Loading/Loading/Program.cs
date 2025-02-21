using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loading
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("□□□□□□□□□□");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("■□□□□□□□□□");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("■■□□□□□□□□");
            //Console.Clear();

            Console.Write("이름을 입력하세요 : ");
            string userName = Console.ReadLine();

            Console.WriteLine($"안녕하세요 {userName}님!");
            Console.Write("나이를 입력하세요 : ");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            Console.WriteLine($"내년에는 {age + 1} 살이 되시겠네요");




        }
    }
}
