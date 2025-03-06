using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    public class MainGame
    {
        
        Player player;
        Field field;
        int input;

        
        public void Initialize()
        {
            player = new Player();

            player.Set_Player_Info();
        }

        public void Progress()
        {
            while (true)
            {
                player.Render();
                //Draw_Map();
                Console.WriteLine("1.사냥터 2.종료");
                input = int.Parse(Console.ReadLine());
                if (input == 2) break;
                if (input == 1)
                {
                    if(field == null)
                    {
                        field = new Field();
                        field.Set_Player(player);
                    }
                    field.Progress();
                }
                    
            }
        }
    }
}
