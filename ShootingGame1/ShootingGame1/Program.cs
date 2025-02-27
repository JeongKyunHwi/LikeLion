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
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            int x = 10, y = 10;
            Console.CursorVisible = false;
            ConsoleKeyInfo keyInfo;

            string[] player = new string[]
            {
                "->",
                ">>>",
                "->",
            };

            //시간 1초 루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long prev_second = stopwatch.ElapsedMilliseconds; // 1/1000 -> 1000일때 1초


            int playerX = 0;
            int playerY = 12;
            while (true)
            {
                
                long current_second = stopwatch.ElapsedMilliseconds; // 현재 시간 가져오기
                if(current_second - prev_second >= 300)
                {
                    Console.Clear();
                    keyInfo = Console.ReadKey(true);
                    //Console.WriteLine("1초루프");
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                        case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 3) playerY++; break;
                        case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                        case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 1) playerX++; break;
                        case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                        case ConsoleKey.Escape: return;

                    }
                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔 좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //콘솔 문자열 출력
                        Console.WriteLine(player[i]);


                    }
                    prev_second = current_second; // 이전 시간 업데이트
                }
                

                
                

            }
            

            //while (true)
            //{
            //    Console.Clear();

            //    Console.SetCursorPosition(x, y);
            //    Console.Write("○"); // 현재 위치 출력
            //    keyInfo = Console.ReadKey(true);

            //    switch (keyInfo.Key)
            //    {
            //        case ConsoleKey.UpArrow: if (y > 0) y--; break;
            //        case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
            //        case ConsoleKey.LeftArrow: if (x > 0) x--; break;
            //        case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
            //        case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
            //        case ConsoleKey.Escape: return;

            //    }

            //}


        }
    }
}
