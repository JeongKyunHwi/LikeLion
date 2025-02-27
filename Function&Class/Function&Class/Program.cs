using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dev1
{
    class Myclass
    {
        public static void SayHello()
        {
            Console.WriteLine("ㅎㅇ Mynamespace 의 Myclass입니다.");
        }
    }
}
namespace Function_Class
{
    class Program
    {

        static void Greet(string name = "손님")
        {
            Console.WriteLine($"안녕하세요, {name}");
        }


        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static void Divide(int a, int b, out int quotient, out int reminder)
        {
            quotient = a / b;
            reminder = a % b;

        }

        static void Increase(ref int num)
        {
            num += 10;
        }

        static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach (int num in numbers)
            {
                total += num;
            }
            return total;
        }

        static int Factorial(int num)
        {
            if (num <= 1) return 1;

            return num * Factorial(num - 1);
        }

        static void Main(string[] args)
        {
            //Greet();
            //Greet("XX님");
            //Console.WriteLine(Multiply(3, 4));
            //Console.WriteLine(Multiply(2.5, 3.5));
            //int q, r;
            //Divide(10, 3, out q, out r);
            //Console.WriteLine($"몫 : {q}");
            //Console.WriteLine($"나머지 : {r}");
            //int value = 5;
            //Increase(ref value);
            //Console.WriteLine(value);
            //Console.WriteLine(Sum(1, 2, 3));
            //Console.WriteLine(Sum(1, 2, 3,4,5,6,7,8,9,10));
            //Console.WriteLine(Factorial(5));
            //dev1.Myclass.SayHello();

            //Console.WriteLine(AddArrow(5, 6));


        }
        static int AddArrow(int a, int b) => a + b;
    }
}
