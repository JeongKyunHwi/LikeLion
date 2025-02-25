using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.SetWindowSize(120, 25);

            //텍스트 RPG
            //설정 몬스터 슬라임 , 스켈레톤 , 보스
            //아이템 장착 강화 캐릭터 상태
            //1.탐험 , 2.장비뽑기 (강화) , 3.휴식 , 4. 종료
            Random random = new Random();
            int input = 0;
            string equip = "주먹";
            int gatcha;
            int equipState = 0;
            int enhanceState = 0;
            int health = 100;
            int att = 10;
            int m_state;
            int e_state;
            int slime_hp ;
            int slime_att = 5;
            int skeleton_hp ;
            int skeleton_att = 20;
            int boss_hp ;
            int boss_att = 50;
            int gold = 5000;
            int treasure;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"현재 캐릭터 상태 || 체력 : {health} || 장착한 무기 : +{enhanceState} {equip} || 공격력 : {att} || 골드 : {gold} ");
                Console.WriteLine("1. 탐험하기");
                Console.WriteLine("2. 장비뽑기");
                Console.WriteLine("3. 휴식하기");
                Console.WriteLine("4. 종료하기");
                Console.Write("입력: ");
                input = int.Parse(Console.ReadLine());
                if (health <= 0)
                {
                    Console.WriteLine("체력이 부족합니다 휴식을 취하겠습니다!");
                    input = 3;
                }
                if (input == 1)
                {
                    Console.WriteLine("탐험을 시작합니다.");
                    Thread.Sleep(500);
                    Console.WriteLine("탐험을 시작합니다..");
                    Thread.Sleep(500);
                    Console.WriteLine("탐험을 시작합니다...");
                    Thread.Sleep(500);

                    e_state = random.Next(1, 10);

                    if (e_state < 5)
                    {
                        slime_hp = 30;
                        skeleton_hp = 150;
                        boss_hp = 5000;
                        //몬스터 출현
                        m_state = random.Next(1, 1001);
                        if (m_state < 499)
                        {
                            Console.WriteLine("슬라임이 출현했다!");
                            while (true)
                            {

                                Console.WriteLine($"나의 공격! 슬라임 체력({slime_hp}) - ({att})");
                                Thread.Sleep(500);
                                slime_hp -= att;
                                if (slime_hp <= 0)
                                {
                                    Console.WriteLine("슬라임 처치!");
                                    Console.WriteLine("10골드 획득");
                                    Thread.Sleep(2000);
                                    gold += 10;
                                    break;
                                }
                                Console.WriteLine($"슬라임의 공격! 나의 체력({health}) - ({slime_att})");
                                Thread.Sleep(500);
                                health -= slime_att;
                                if (health <= 0)
                                {
                                    Console.WriteLine("슬라임에게 처치당했다...");
                                    Thread.Sleep(1000);
                                    break;
                                }
                            }
                        }
                        else if (m_state < 999)
                        {
                            Console.WriteLine("스켈레톤이 출현했다!");
                            while (true)
                            {

                                Console.WriteLine($"나의 공격! 스켈레톤 체력({skeleton_hp}) - ({att})");
                                skeleton_hp -= att;
                                Thread.Sleep(500);
                                if (skeleton_hp <= 0)
                                {
                                    Console.WriteLine("스켈레톤 처치!");
                                    Console.WriteLine("250골드 획득");
                                    gold += 250;
                                    Thread.Sleep(500);
                                    break;
                                }
                                Console.WriteLine($"스켈레톤의 공격! 나의 체력({health}) - ({skeleton_att})");
                                health -= skeleton_att;
                                Thread.Sleep(500);
                                if (health <= 0)
                                {
                                    Console.WriteLine("스켈레톤에게 처치당했다...");
                                    Thread.Sleep(500);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("보스가 출현했다!");
                            while (true)
                            {

                                Console.WriteLine($"나의 공격! 스켈레톤 체력({boss_hp}) - ({att})");
                                boss_hp -= att;
                                Thread.Sleep(500);
                                if (boss_hp <= 0)
                                {
                                    Console.WriteLine("보스 처치!");
                                    Console.WriteLine("5000골드 획득");
                                    gold += 5000;
                                    Thread.Sleep(500);
                                    break;
                                }
                                Console.WriteLine($"보스의 공격! 나의 체력({health}) - ({boss_att})");
                                health -= boss_att;
                                Thread.Sleep(500);
                                if (health <= 0)
                                {
                                    Console.WriteLine("보스에게 처치당했다...");
                                    Thread.Sleep(500);
                                    break;
                                }
                            }
                        }
                    }
                    else if (e_state < 8)
                    {
                        treasure = random.Next(50, 1250);
                        Console.WriteLine($"보물을 발견했다! 골드 {treasure} 획득");
                        gold += treasure;
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("아무일도 없었다.");
                        Thread.Sleep(1000);
                    }

                }
                else if (input == 2)
                {
                    if (gold >= 1000)
                    {
                        gold -= 1000;
                        gatcha = random.Next(1, 1001);
                        if (gatcha < 500)
                        {
                            Console.WriteLine($"강철검 획득");
                            if (equipState > 1)
                            {
                                Console.WriteLine("현재 장착한 무기가 더 좋습니다.");
                                Thread.Sleep(500);
                            }
                            else if (equipState == 1)
                            {
                                Console.WriteLine("동일한 무기를 획득했습니다.");
                                if (enhanceState == 3)
                                {
                                    Console.WriteLine("강화수치가 최대입니다.");
                                    Thread.Sleep(500);
                                }
                                else
                                {
                                    Console.WriteLine("강철검을 착용하고있으니 강화하겠습니다.");
                                    Console.WriteLine($"+{++enhanceState}강철검 획득.");
                                    Thread.Sleep(500);
                                    att += 5;
                                }
                            }
                            else
                            {
                                Console.WriteLine("강철검 장착!");
                                att += 5;
                                equipState = 1;
                                equip = "강철검";
                                enhanceState = 0;
                                Thread.Sleep(500);
                            }
                        }
                        else if (gatcha < 900)
                        {
                            Console.WriteLine($"마법검 획득");
                            if (equipState > 2)
                            {
                                Console.WriteLine("현재 장착한 무기가 더 좋습니다.");
                                Thread.Sleep(500);
                            }
                            else if (equipState == 2)
                            {
                                Console.WriteLine("동일한 무기를 획득했습니다.");
                                if (enhanceState == 3)
                                {
                                    Console.WriteLine("강화수치가 최대입니다.");
                                    Thread.Sleep(500);
                                }
                                else
                                {
                                    Console.WriteLine("마법검을 착용하고있으니 강화하겠습니다.");
                                    Console.WriteLine($"+{++enhanceState}마법검 획득.");
                                    att += 20;
                                    Thread.Sleep(500);
                                }
                            }
                            else
                            {
                                Console.WriteLine("마법검 장착!");
                                att = 10;
                                att += 20;
                                equipState = 2;
                                enhanceState = 0;
                                equip = "마법검";
                                Thread.Sleep(500);
                            }

                        }
                        else
                        {
                            Console.WriteLine($"용사의 검 획득");
                            if (equipState > 3)
                            {
                                Console.WriteLine("현재 장착한 무기가 더 좋습니다.");
                                Thread.Sleep(500);
                            }
                            else if (equipState == 3)
                            {
                                Console.WriteLine("동일한 무기를 획득했습니다.");
                                if (enhanceState == 3)
                                {
                                    Console.WriteLine("강화수치가 최대입니다.");
                                    Thread.Sleep(500);
                                }
                                else
                                {
                                    Console.WriteLine("용사의 검을 착용하고있으니 강화하겠습니다.");
                                    Console.WriteLine($"+{++enhanceState}용사검 획득.");
                                    att += 120;
                                    Thread.Sleep(500);
                                }
                            }
                            else
                            {
                                Console.WriteLine("용사의 검 장착!");
                                att = 10;
                                att += 120;
                                equipState = 3;
                                enhanceState = 0;
                                equip = "용사의 검";
                                Thread.Sleep(500);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다.");
                        Thread.Sleep(500);
                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine($"휴식을 취합니다 체력 20 회복!");
                    health += 20;
                    Thread.Sleep(1000);
                    input = 0;
                }
                else if (input == 4)
                {
                    Console.WriteLine("게임을 종료합니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 입력하세요.");
                    Thread.Sleep(1000);
                }


            }
        }
    }
}


