using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGTask
{
    public class GameManager
    {
        public Player player = new Player();
        public Field field;
        public void Initialize()
        {
            player.Initialize();
            player.Select_Job();
        }

        public void Progress()
        {

            while (true)
            {
                player.Render();
                int input;
                Console.WriteLine("1. 사냥터 2. 종료");
                input = int.Parse(Console.ReadLine());
                if (input == 2) { break; }
                if (input == 1)
                {
                    if (field == null)
                    {
                        field = new Field();
                    }
                    
                    while (true)
                    {
                        Console.Clear();
                        player.Render();
                        field.Draw_Map();
                        input = int.Parse(Console.ReadLine());

                        if (input == 1) //초보몹
                        {
                            field.CreateMonster(input);
                            
                        }
                        else if (input == 2) //중수몹
                        {
                            field.CreateMonster(input);
                            
                        }
                        else if (input == 3) // 고수몹
                        {
                            field.CreateMonster(input);
                            
                        }
                        else if (input == 4) //전단계
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력, 다시 입력하세요.");
                        }
                        //field.Render(player);
                        field.Fight(player);
                        
                    }
                    

                }
                else
                {
                    Console.WriteLine("잘못된 입력");
                }
            }
        }


    }
}
