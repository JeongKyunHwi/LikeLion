using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Field
    {
        Player player = null;
        Monster monster = null;

        public void Set_Player(Player player) { this.player = player; }
        //맵 선택 후
        //몬스터 생성

        public void Create(string _name, int _hp, int _att, out Monster _monster)
        {
            _monster = new Monster();
            INFO M_info = new INFO();

            M_info.Name = _name;
            M_info.Hp = _hp;
            M_info.Attack = _att;

            _monster.Set_Monster_Info(M_info);
        }
        public void CreateMonster(int input)
        {

            //1번 초보몹(몬스터가 가지는 속성 : 이름, 체력, 공격력)
            if (input == 1)
            {
                Create("초보몹", 30, 3, out monster);
            }
            else if (input == 2)
            {
                Create("중수몹", 60, 6, out monster);
            }
            else if (input == 3)
            {
                Create("고수몹", 90, 9, out monster);
            }
            //2번 중수몹

            //3번 고수몹
        }
        //전투
        public void Fight()
        {
            int input = 0;
            while (true)
            {
                Console.Clear();
                player.Render();
                monster.Render();

                Console.WriteLine("1.공격 2.도망");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    monster.Set_Damage(player.Player_Info.Attack);
                    player.Set_Damage(monster.Monster_Info.Attack);
                    if (player.Player_Info.Hp <= 0)
                    {
                        if (player.Player_Info.Name == "기사")
                        {
                            player.Player_Info.Hp = 100;
                            break;
                        }
                        else if (player.Player_Info.Name == "마법사")
                        {
                            player.Player_Info.Hp = 90;
                            break;
                        }
                        else if (player.Player_Info.Name == "도적")
                        {
                            player.Player_Info.Hp = 85;
                            break;
                        }
                    }
                }
                if (input == 2 || monster.Monster_Info.Hp <= 0)
                {
                    monster = null;
                    break;
                }
            }
        }
        public void Progress()
        {
            int input;
            while (true)
            {
                Console.Clear();
                player.Render();
                Draw_Map();
                input = int.Parse(Console.ReadLine());
                if (input == 4) break;
                if (input <= 3)
                {
                    CreateMonster(input);

                    Fight();
                }
            }
        }
        public void Draw_Map()
        {
            Console.WriteLine("==========");
            Console.WriteLine("1.초보맵");
            Console.WriteLine("2.중수맵");
            Console.WriteLine("3.고수맵");
            Console.WriteLine("4.전단계");
            Console.WriteLine("입력 : ");
        }
    }
}
