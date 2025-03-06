using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Player
    {
        public INFO Player_Info ;
        
        public void Set_Player_Info()
        {
            int input = 0;
            while (true)
            {
                Player_Info = new INFO();
                Console.WriteLine("직업을 선택하세요. (1.전사 2.마법사 3.도적)");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Player_Info.Name = "기사";
                    Player_Info.Hp = 100;
                    Player_Info.Attack = 10;
                    break;
                }
                else if (input == 2)
                {
                    Player_Info.Name = "마법사";
                    Player_Info.Hp = 90;
                    Player_Info.Attack = 15;
                    break;
                }
                else if (input == 3)
                {
                    Player_Info.Name = "도적";
                    Player_Info.Hp = 85;
                    Player_Info.Attack = 13;
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력.");
                }
            }
            
        }
        public INFO Get_Player_Info(INFO player_info)
        {
            return player_info;
        }
        public void Set_Damage(int damage)
        {
            Player_Info.Hp -= damage;
        }

        public void Render()
        {
            Console.Clear();
            Console.WriteLine("===========");
            Console.WriteLine($"플레이어 : {Player_Info.Name}");
            Console.WriteLine($"체력 : {Player_Info.Hp}\t 공격력:{Player_Info.Attack}");

        }
    }
}
