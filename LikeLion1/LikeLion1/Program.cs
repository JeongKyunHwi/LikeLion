using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion1
{
    class Program
    {
        static void Main(string[] args)
        {
            //출력
            Console.WriteLine("Github 연결 하기");

            //변수 선언
            int age; //정수형 변수
            age = 25;

            Console.WriteLine(age);

            //리터럴 사용하기
            int number = 10;
            double pi = 3.14;
            char letter = 'A';
            string name = "Alice";

            Console.WriteLine(number);
            Console.WriteLine(pi);
            Console.WriteLine(letter);
            Console.WriteLine(name);

            //캐릭터 hp 100 , att 56.7 , 이름, 등급 S

            int hp = 100;
            double att = 56.7;
            name = "Jinwoo";
            char grade = 'S';
            Console.WriteLine();
            Console.WriteLine("캐릭터");
            Console.WriteLine("hp : " + hp);
            Console.WriteLine("공격력 : " + att);
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("등급 : " + grade);

        }
    }
}
