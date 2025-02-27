using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShootingGame1
{
    class Program
    {
        struct Shooting_Game
        {
            public int start_x;
            public int start_y;
            public ConsoleKeyInfo keyInfo;

            public string[] player;

            public void Update()
            {
                Console.Clear();
                for (int i = 0; i < player.Length; i++)
                {
                    //콘솔 좌표 설정 플레이어X 플레이어Y
                    Console.SetCursorPosition(start_x, start_y + i);
                    //콘솔 문자열 출력
                    Console.WriteLine(player[i]);
                }
            }

            public void Player_Move()
            {
                keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (start_y > 0) start_y--; break;
                    case ConsoleKey.DownArrow: if (start_y < Console.WindowHeight - 3) start_y++; break;
                    case ConsoleKey.LeftArrow: if (start_x > 0) start_x--; break;
                    case ConsoleKey.RightArrow: if (start_x < Console.WindowWidth - 1) start_x++; break;
                    case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                    case ConsoleKey.Escape: return;
                }
            }

            public void Initialize(int a, int b)
            {
                Console.SetWindowSize(80, 25);
                Console.SetBufferSize(80, 25);

                start_x = a;
                start_y = b;

                Console.CursorVisible = false;

                player = new string[] 
                {
                    "->",
                    ">>>",
                    "->",
                };


            }
        }
        static void Main(string[] args)
        {
            Shooting_Game shooting_Game = new Shooting_Game();
            shooting_Game.Initialize(0, 12);

            //시간 1초 루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long prev_second = stopwatch.ElapsedMilliseconds; // 1/1000 -> 1000일때 1초   
            while (true)
            {
                long current_second = stopwatch.ElapsedMilliseconds; // 현재 시간 가져오기
                if (current_second - prev_second >= 300)
                {
                    shooting_Game.Player_Move();
                    shooting_Game.Update();
                    prev_second = current_second; // 이전 시간 업데이트
                }
            }
        }
    }
}
