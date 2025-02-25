using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project_adventurer_raise
{
    class Program
    {

        static void Main(string[] args)
        {
            

            Random random = new Random();

            int gold = 500;
            int health = 100;
            int power = 10;
            int input;
            bool isAlive = true;

            Console.WriteLine(" ⚔️ 모험가 키우기 ⚔️ ");
            Thread.Sleep(1000);

            while (isAlive)
            {
                Console.Clear();

                Console.WriteLine($"현재 상태 : 체력{health} | Gold : {gold} | 공격력 : {power}");
                Console.WriteLine("\n1. 탐험하기 🏕️");
                Console.WriteLine("2. 장비 뽑기 (1000골드) 🎲");
                Console.WriteLine("3. 휴식 하기 (체력 +20) 💤");
                Console.WriteLine("4. 게임 종료");
                Console.Write("입력: ");

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine(" 탐험을 떠납니다 . ");
                    Thread.Sleep(500);
                    Console.WriteLine(" 탐험을 떠납니다 .. ");
                    Thread.Sleep(500);
                    Console.WriteLine(" 탐험을 떠납니다 ... ");
                    Thread.Sleep(500);
                    Console.WriteLine(" 탐험을 떠납니다 .... ");
                    Thread.Sleep(500);
                    Console.WriteLine(" 탐험을 떠납니다 ..... ");

                    int eventChance = random.Next(1, 101);

                    if (eventChance <= 30)
                    {
                        int damage = random.Next(5, 21);
                        Console.WriteLine($" ⚔️ 몬스터를 만났습니다! (체력 -{damage})");
                        health -= damage;
                    }
                    else if (eventChance <= 70)
                    {
                        int reward = random.Next(100, 301);
                        Console.WriteLine($" 💰 보물을 발견했습니다! (골드 +{reward}");
                        gold += reward;
                    }
                    else
                    {
                        int heal = random.Next(10, 31);
                        Console.WriteLine($" 🌿 신비한 약초를 발견했습니다! (체력 +{heal}");
                        health += heal;
                    }

                    if (health <= 0)
                    {
                        Console.WriteLine("\n 💀 체력이 0이 되어 사망했습니다... 게임오버!");
                        isAlive = false;
                    }
                    Thread.Sleep(2000);
                }
                else if (input == 2)
                {
                    if (gold >= 1000)
                    {
                        gold -= 1000;
                        Console.Clear();
                        Console.WriteLine(" 🎲 장비를 뽑습니다...");
                        Thread.Sleep(1000);

                        int rnd = random.Next(1, 101);
                        if (rnd == 1)
                        {
                            Console.WriteLine("SSS급 전설의 검(공격력 + 50) 획득!");
                            power += 50;
                        }
                        else if (rnd <= 10)
                        {
                            Console.WriteLine("SS급 희귀한 검(공격력 + 30) 획득!");
                            power += 30;
                        }
                        else if (rnd <= 30)
                        {
                            Console.WriteLine("S급 강철의 검(공격력 + 20) 획득!");
                            power += 20;
                        }
                        else
                        {
                            Console.WriteLine("녹슨칼(공격력 +5) 획득!");
                            power += 5;
                        }
                        Thread.Sleep(5000);

                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다. (1000골드 필요) ");
                        Thread.Sleep(1000);
                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine(" 휴식을 취합니다... (체력 + 20)");
                    health += 20;
                    Thread.Sleep(2000);
                }
                else if (input == 4)
                {
                    Console.WriteLine("게임을 종료합니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 선택하세요.");
                    Thread.Sleep(1000);

                }



            }
            

        }
    }
}
