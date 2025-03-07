using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextRPGTask
{
    public class Field
    {
        public Player player;
        public Monster monster;

        public void Draw_Map()
        {
            Console.WriteLine("===============");
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("입력:");
        }
        //public void Create(string _name, int _hp, int _att, out Monster _monster)
        //{
        //    Monster monster = new Monster();
        //    monster.Name = _name;
        //    monster.Hp = _hp;
        //    monster.Att = _att;

        //}

        //몬스터 생성
        public void CreateMonster(int i)
        {
            if (i == 1)
            {
                monster = new Monster();
                monster.Name = "초보몹";
                monster.Hp = 30;
                monster.Att = 3;
            }
            else if (i == 2)
            {
                monster = new Monster();
                monster.Name = "중수몹";
                monster.Hp = 60;
                monster.Att = 6;
            }
            else if (i == 3)
            {
                monster = new Monster();
                monster.Name = "고수몹";
                monster.Hp = 90;
                monster.Att = 9;
            }
        }
        public void Render(Player player)
        {
            player.Render();
            monster.Render();
        }

        public void Fight(Player player)
        {
            int i;
            while (true)
            {
                Render(player);
                Console.WriteLine("1.공격 2.도망");
                i = int.Parse(Console.ReadLine());
                
                if (i == 2) break;
                if (i == 1)
                {
                    monster.Hp -= player.playerData.Att;
                    player.playerData.Hp -= monster.Att;
                    if (monster.Hp <= 0) break;
                    if (player.playerData.Hp <= 0) 
                    {
                        player.SetHP(player.playerData);
                        break; 
                    }
                }
            }
        }

    }
}
