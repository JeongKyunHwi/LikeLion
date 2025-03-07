using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGTask
{
    public class Player
    {
        public PlayerData playerData;

        public void Select_Job()
        {
            while (true)
            {
                int input;
                Console.WriteLine("직업을 선택하세요. (1.기사 2.마법사 3.도적)");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    playerData.Name = "기사";
                    playerData.Hp = 100;
                    playerData.Att = 10;
                    break;
                }
                else if (input == 2)
                {
                    playerData.Name = "마법사";
                    playerData.Hp = 90;
                    playerData.Att = 15;
                    break;
                }
                else if (input == 3)
                {
                    playerData.Name = "도적";
                    playerData.Hp = 85;
                    playerData.Att = 13;
                    break;
                }
                else
                {
                    Console.WriteLine("다시 입력하세요.");
                }
            }
        }
        public void Initialize()
        {
            playerData = new PlayerData();
            playerData.Name = "";
            playerData.Hp = 0;
            playerData.Att = 0;
        }
        public void Render()
        {
            Console.Clear();
            Console.WriteLine("=======================");
            Console.WriteLine($"플레이어 : {playerData.Name}");
            Console.WriteLine($"체력 : {playerData.Hp} \t 공격력 : {playerData.Att}");

        }



        public void SetHP(PlayerData pd)
        {
            if (pd.Name == "기사")
                playerData.Hp = 100;
            if (pd.Name == "마법사")
                playerData.Hp = 90;
            if (pd.Name == "도적")
                playerData.Hp = 85;
        }
    }
}
