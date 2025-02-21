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

            Console.WriteLine();
            string greeting;
            greeting = "Hello, World!";
            Console.WriteLine(greeting);

            Console.WriteLine();
            int score = 100;
            double temperature = 36.5;
            string city = "Seoul";

            Console.WriteLine(score);
            Console.WriteLine(temperature);
            Console.WriteLine(city);

            Console.WriteLine();
            int x = 10, y = 20, z = 30;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine();
            const double Pi = 3.14159;
            const int MaxScore = 100;
            Console.WriteLine("Pi : " + Pi);
            Console.WriteLine("Max Score : " + MaxScore);

            Console.WriteLine();
            //로스트아크 캐릭터 스탯
            double level = 1391.66;
            int attack = 16755, maxHp = 78103, Cri = 36, a=1017, b=41, c=611, d=22, e=39;

            Console.WriteLine("로스트아크 캐릭터 스텟");
            Console.WriteLine("아이템 레벨 : " + level);
            Console.WriteLine("공격력 : " + attack);
            Console.WriteLine("최대 생명력 : " + maxHp);
            Console.WriteLine("치명 : " + Cri);
            Console.WriteLine("특화 : " + a);
            Console.WriteLine("제압 : " + b);
            Console.WriteLine("신속 : " + c);
            Console.WriteLine("인내 : " + d);
            Console.WriteLine("숙련 : " + e);





        }
    }
}
