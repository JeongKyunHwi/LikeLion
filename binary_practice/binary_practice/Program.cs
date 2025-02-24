using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("2진수를 입력하세요 : ");
            //string binaryInput = Console.ReadLine();

            //int decimalValue = Convert.ToInt32(binaryInput, 2);

            //string binaryOutput = Convert.ToString(decimalValue, 2);

            //Console.WriteLine($"입력한 이진수 : {binaryInput}");
            //Console.WriteLine($"변환된 10진수 : {decimalValue}");
            //Console.WriteLine($"변환된 이진수 : {binaryOutput}");

            //var name = "Alice";
            //var age = 25;
            //var isStudent = true;

            //Console.WriteLine($"이름 : {name} , 나이 : {age} , 학생인가 {isStudent}");

            //int defaultint = default;
            //string defaultstring = default;
            //bool defaultbool = default;

            //Console.WriteLine($"디폴트 인트 : {defaultint}, 디폴트스트링 : {defaultstring}, 디폴트불 : {defaultbool}");

            //int a = 5 ,b = 3;
            //int sum = a + b;
            //bool isEqual = a == b;

            //Console.WriteLine($"a+b = {sum}");
            //sum = a % b;
            //Console.WriteLine($"a%b = {sum}");
            //Console.WriteLine($"a와 b는 같은가? {isEqual}");

            //int number = 5;
            //bool flag = true;
            //Console.WriteLine(-number);
            //Console.WriteLine(!flag);

            // ~ 비트 반전

            //int num = 10;
            //int result = ~num;

            //Console.WriteLine(result);

            //double pi = 3.14;
            //int IntegerPi = (int)pi;

            //Console.WriteLine(IntegerPi);

            //int kor = 90;
            //int eng = 75;
            //int mat = 58;

            //int sum = 0;
            //float average = 0.0f;


            //sum = kor + eng + mat;
            //average = (float)sum / 3;
            //Console.WriteLine("평균 : " + average);

            //int a = 10, b = 3;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            //string firstName = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine(firstName + " " + lastName);

            //int a = 10;
            //a += 5;
            //Console.WriteLine(a);
            //a -= 5;
            //Console.WriteLine(a);
            //a *= 5;
            //Console.WriteLine(a);
            //a /= 5;
            //Console.WriteLine(a);
            //a %= 5;
            //Console.WriteLine(a);

            // 평균 프로그램 국 영 수 3과목 입력받기 총점과 평균

            //int kor, eng, math , sum;
            //float average;
            //Console.Write("국어 점수를 입력하세요 : ");
            //kor = Int32.Parse( Console.ReadLine());
            //Console.Write("영어 점수를 입력하세요 : ");
            //eng = Int32.Parse(Console.ReadLine());
            //Console.Write("수학 점수를 입력하세요 : ");
            //math = Int32.Parse(Console.ReadLine());

            //sum = kor + eng + math;
            //Console.WriteLine("총점 : " + sum);
            //average = (float)sum / 3;
            //Console.WriteLine("평균 : " + average.ToString("F2"));

            //// 정수를 입력받아 비트 반전 결과 출력
            //int i;
            //Console.Write("정수를 입력하세요 : ");
            //i = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("입력받은 정수 비트 반전 결과 : " + ~i);

            //int b = 3;
            //Console.WriteLine(b++);

            //Console.WriteLine(b);
            //Console.WriteLine(++b);

            //int x = 5, y = 10;

            //Console.WriteLine(x == y);
            //Console.WriteLine(x < y);
            //Console.WriteLine(x != y);

            //bool a = true;
            //bool b = false;


            //Console.WriteLine(a && b);
            //Console.WriteLine(a || b);
            //Console.WriteLine(!a);

            //int x = 5; //0101
            //int y = 3; //0011

            //Console.WriteLine(x & y); // 1
            //Console.WriteLine(x | y); // 7
            //Console.WriteLine(x ^ y); // 6
            //Console.WriteLine(~x); // -6

            //int x = 5; // 0101
            //Console.WriteLine(x << 1); // 1010
            //Console.WriteLine(x >> 1); // 0010

            //int a = 10;
            //int b = 20;

            //int max;
            //max = (a < b) ? a : b; // 삼항 연산자 (괄호 안의 조건이 참일 경우 a 거짓일 경우 b) (비교) ? 참 : 거짓

            //Console.WriteLine(max); // a출력

            //int i = (10 + 2) * 5;

            //Console.WriteLine(i);

            //int score = 85;
            //if(score >= 90)
            //{
            //    Console.WriteLine("A학점 입니다.");
            //}
            //else if(score >= 80)
            //{
            //    Console.WriteLine("B학점 입니다.");

            //}
            //else
            //{
            //    Console.WriteLine("재시험입니다.");
            //}

            //소지금 입력
            //Console.Write("소지금 입력 : ");
            //int i = int.Parse(Console.ReadLine());
            //int att = 0;
            //if(i <= 100)
            //{
            //    Console.WriteLine("무한의 대검");
            //    att += 1;
            //}
            //else if (i <= 200)
            //{
            //    Console.WriteLine("카타나");
            //    att += 2;
            //}
            //else if (i <= 300)
            //{
            //    Console.WriteLine("진은검");
            //    att += 3;
            //}
            //else if (i <= 400)
            //{
            //    Console.WriteLine("집판검");
            //    att += 4;

            //}else if (i <= 500)
            //{
            //    Console.WriteLine("엑스칼리버");
            //    att += 5;
            //}
            //else if( i<=600)
            //{
            //    Console.WriteLine("유령검");
            //    att += 6;
            //}
            //else
            //{
            //    Console.WriteLine("전설의 검");
            //    att += 7;
            //}

            //Console.Write("캐릭터 이름: ");
            //Console.ReadLine();
            //Console.WriteLine("공격력 : 100 + " + att);

            // 세 정수의 최댓값 구하기
            int x, y, z;
            Console.WriteLine("세 정수를 입력하세요 ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            if (x >= y && x >= z)
            {
                Console.WriteLine("최대값 : " + x);
            }
            else if (y >= x && y >= z)
            {
                Console.WriteLine("최대값 : " + y);
            }
            else
            {
                Console.WriteLine("최대값 : " + z);
            }

            // 점수에 따른 학점 평가 
            // 90 이상: A 학점
            //80 이상 90 미만: B 학점
            //70 이상 80 미만: C 학점
            //60 이상 70 미만: D 학점
            //60 미만: F 학점
            int score;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("점수를 입력하세요");
            score = int.Parse(Console.ReadLine());
            if (score > 100)
            {
                Console.WriteLine("점수 초과");
            }
            else if (score >= 90)
            {
                Console.WriteLine("A학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C학점");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D학점");
            }
            else
            {
                Console.WriteLine("F학점");
            }

            int i, j;
            char opt;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("정수 2개를 입력하세요");
            i = int.Parse(Console.ReadLine());
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("연산자를 입력하세요");
            opt = char.Parse(Console.ReadLine());

            if (opt.Equals('+'))
            {
                Console.WriteLine("결과: " + (i + j));
            }
            else if (opt.Equals('-'))
            {
                Console.WriteLine("결과: " + (i - j));
            }
            else if (opt.Equals('*'))
            {
                Console.WriteLine("결과: " + (i * j));
            }
            else if (opt.Equals('/'))
            {
                Console.WriteLine("결과: " + (i / j));
            }


        }
    }
}
