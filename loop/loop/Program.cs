﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //int day = 3;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    default:
            //        Console.WriteLine("유효하지 않은 숫자");
            //        break;
            //}

            //int i;

            //Console.WriteLine("숫자를 입력해 캐릭터를 선택하세요. 1.검사 , 2.마법사 , 3.도적");
            //i = int.Parse(Console.ReadLine());

            //switch (i)
            //{
            //    case 1:
            //        Console.WriteLine("검사를 선택하셨습니다. 능력치는 아래와 같습니다.");
            //        Console.WriteLine("공격력 : 100");
            //        Console.WriteLine("방어력 : 90");
            //        break;
            //    case 2:
            //        Console.WriteLine("마법사를 선택하셨습니다. 능력치는 아래와 같습니다.");
            //        Console.WriteLine("공격력 : 110");
            //        Console.WriteLine("방어력 : 80");
            //        break;
            //    case 3:
            //        Console.WriteLine("도적을 선택하셨습니다. 능력치는 아래와 같습니다.");
            //        Console.WriteLine("공격력 : 115");
            //        Console.WriteLine("방어력 : 70");
            //        break;
            //    default:
            //        Console.WriteLine("잘못된 숫자를 입력하셨습니다.");
            //        break;
            //}

            //for(int i = 0; i<5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write(i + " ");
            //}
            //int sum = 0;
            //for(int i =1; i<=10; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //int i = 1;
            //while (i <= 5)
            //{
            //    Console.WriteLine("i : " + i);
            //    i++;
            //}

            //while (true)
            //{
            //    Console.WriteLine("loop");
            //    i++;
            //    if (i > 7)
            //    {
            //        break;
            //    }
            //}

            //Random rand = new Random();

            ////0~10미만의 임의의 정수
            //for (int i = 0; i < 10; i++)
            //{
            //    double randomNumber = rand.NextDouble(); //0~9
            //    Console.WriteLine(randomNumber);
            //}

            //대장장이 키우기
            //도끼 등급 SSS 10% , SS 40% , S 50%

            //Random rand = new Random();

            //int opt = 0;
            //int grade = 0;
            //while (true)
            //{
            //    Console.WriteLine("도끼를 뽑으시려면 1, 멈추려면 2를 입력: ");
            //    opt = int.Parse(Console.ReadLine());

            //    if(opt == 2)
            //    {
            //        break;
            //    }
            //    grade = rand.Next(0, 10);
            //    if (grade < 5)
            //    {
            //        Console.WriteLine("S등급 도끼를 뽑았다.");
            //    }else if (grade < 9)
            //    {
            //        Console.WriteLine("SS등급 도끼를 뽑았다.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("SSS등급 도끼를 뽑았다.");
            //    }
            //}
            //for(int i =0; i<10; i++)
            //{

            //    if (i == 5)
            //        break;
            //    Console.WriteLine(i);
            //}

            //continue
            //현재 반복을 건너뛰고 다음 반복으로 넘어간다.
            //for(int i =0; i<10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //goto
            //int n = 1;
            //start:
            //if (n <= 5)
            //{
            //    Console.WriteLine(n);
            //    n++;

            //    goto start;
            //}

            //project black smith

            Random random = new Random();

            Console.WriteLine(" 대장장이 키우기 ");

            int pmoney = 100;
            int input;
            int rnd;

            Thread.Sleep(500);

            while (true)
            {
                Console.Clear();
                Console.Write("1. 나무캐기 ");
                Console.Write("2. 장비뽑기 ");
                Console.WriteLine("3. 나가기");
                Console.Write("입력 : ");
                input = int.Parse(Console.ReadLine());

                if(input == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("나무캐기(엔터)");
                        Console.WriteLine("뒤로가기 x");

                        string str = Console.ReadLine();

                        pmoney += 100;
                        Console.WriteLine("소지금 : " + pmoney);
                        if (str == "x")
                        {
                            Console.WriteLine("뒤로가기");
                            break;
                        }
                    }
                }
                else if(input == 2)
                {
                    if (pmoney >= 1000)
                    {
                        pmoney -= 1000;
                        for(int i =0; i<20; i++)
                        {
                            rnd = random.Next(0, 100);
                            if (rnd == 0)
                            {
                                Console.WriteLine("SSS등급 도끼");
                            }
                            else if(rnd >=1 && rnd <= 5)
                            {
                                Console.WriteLine("SS등급 도끼");

                            }else if(rnd >=6 && rnd <= 16)
                            {
                                Console.WriteLine("S등급 도끼");
                            }
                            else if (rnd >= 17 && rnd <= 37)
                            {
                                Console.WriteLine("A등급 도끼");
                            }
                            else if (rnd >= 38 && rnd <= 68)
                            {
                                Console.WriteLine("B등급 도끼");
                            }
                            else
                            {
                                Console.WriteLine("C등급 도끼");
                            }
                            Thread.Sleep(500);

                        }
                    }
                    else
                    {
                        Console.WriteLine("돈이 부족합니다. \n");
                        Thread.Sleep(1000);
                    }
                } else if (input == 3)
                {
                    Console.WriteLine("나갑니다~");
                    Environment.Exit(0);
                }
                

            }




        }
    }
}
