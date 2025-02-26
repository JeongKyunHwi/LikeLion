using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Study
{
    class Program
    {
        //static void Print()
        //{

        //}
        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}
        static int Max(int x, int y, int z)
        {
            int answer = z;
            if (x > y)
            {
                answer = x;
            }
            if (x > z)
            {
                answer = x;
            }
            if(y>z)
            {
                answer = y;
            }
                return answer;
        }
        static int Ret_String(string s)
        {
            return s.Length;
        }
        static void Add(int a , int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        static void Main(string[] args)
        {
            //int result = Add(10, 20);
            //Console.WriteLine($"10 + 20 = {result}");
            Console.WriteLine("=======문제1=======");
            int[] array = new int[5] { 10, 20, 30, 40, 50 };
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine("\n=======문제2=======");
            int sum = 0;
            int[] array2 = new int[5];
            Console.WriteLine("정수를 입력하세요.");
            for (int i = 0; i < array2.Length; i++)
            {

                array2[i] = int.Parse(Console.ReadLine());
                sum += array2[i];
            }
            Console.WriteLine($"입력받은 정수의 합 : {sum}");

            Console.WriteLine("=======문제3=======");
            //최대값 찾기
            int answer = 0;
            int[] array3 = new int[] { 3, 8, 15, 6, 2 };

            for (int i = 0; i < array3.Length; i++)
            {
                //if (i + 1 == array3.Length) break;
                if (answer < array3[i])
                {
                    answer = array3[i];
                }
            }
            Console.WriteLine("최대값: " + answer);
            //Console.WriteLine("최대값: " + array3.Max());
            
            Console.WriteLine("=======문제4=======");
            for(int i=1; i<=10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n=======문제5=======");
            int index = 1;
            while (index <= 10)
            {
                if (index % 2 == 0)
                {
                    Console.Write(index + " ");
                }
                index++;
            }
            Console.WriteLine("\n=======문제6=======");
            int[] array4 = new int[] { 1, 2, 3, 4, 5 };
            foreach(int i in array4)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n=======문제7=======");
            int a, b;
            Console.WriteLine("두 수를 입력하세요.");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Add(a, b);

            Console.WriteLine("=======문제8======="); //문자열 길이 반환 함수
            string s;
            Console.Write("문자열 입력 : ");
            s = Console.ReadLine();
            Console.WriteLine("문자열 길이 : " + Ret_String(s));
            
            Console.WriteLine("=======문제9=======");
            int x, y, z;
            Console.WriteLine("세 정수를 입력하세요.");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            Console.WriteLine("최대값 : " + Max(x, y, z));

        }


    }
}
