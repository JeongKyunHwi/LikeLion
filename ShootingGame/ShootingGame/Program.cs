using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame
{
    //미사일 클래스
    public class BULLET
    {
        public int x;
        public int y;
        public bool fire;

    }

    //플레이어 클래스
    public class PLAYER
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();

        public int player_x;
        public int player_y;
        public BULLET[] playerBullet = new BULLET[20];
        public BULLET[] playerBullet2 = new BULLET[20];
        public BULLET[] playerBullet3 = new BULLET[20];
        public int Score = 100;
        public ITEM item = new ITEM();
        public int itemCount = 0;


        public PLAYER()
        {
            //플레이어 좌표 위치 초기화
            player_x = 0;
            player_y = 12;

            for (int i = 0; i < playerBullet.Length; i++)
            {
                playerBullet[i] = new BULLET();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;

                playerBullet2[i] = new BULLET();
                playerBullet2[i].x = 0;
                playerBullet2[i].y = 0;
                playerBullet2[i].fire = false;

                playerBullet3[i] = new BULLET();
                playerBullet3[i].x = 0;
                playerBullet3[i].y = 0;
                playerBullet3[i].fire = false;
            }


        }

        public void GameMain()
        {
            //키 입력 부분
            KeyControl();
            //플레이어 그리기
            PlayerDraw();

            UIScore();

            if (item.Item_Life)
            {
                item.ItemMove();
                item.ItemDraw();
                CrashItem();
            }
        }

        public void KeyControl()
        {
            int pressKey;
            if (Console.KeyAvailable) // 키가 눌렸을때 true
            {
                pressKey = _getch(); // 아스키값

                switch (pressKey)
                {
                    case 72: // 위쪽 화살표 키
                        {
                            player_y--;
                            if (player_y < 1)
                            {
                                player_y = 1;
                            }
                            break;
                        }
                    case 75: // 왼쪽 화살표키
                        {
                            player_x--;
                            if (player_x < 0)
                            {
                                player_x = 0;
                            }
                            break;
                        }
                    case 77: //오른쪽 키
                        {
                            player_x++;
                            if (player_x > 75)
                            {
                                player_x = 75;
                            }
                            break;
                        }
                    case 80: //아래 키
                        {
                            player_y++;
                            if (player_y > 22)
                            {
                                player_y = 22;
                            }
                            break;
                        }
                    case 32: // 스페이스바
                        {
                            //미사일 발사 false 발사가능
                            for (int i = 0; i < playerBullet.Length; i++)
                            {
                                if (!playerBullet[i].fire)
                                {
                                    playerBullet[i].fire = true;
                                    playerBullet[i].x = player_x + 5;
                                    playerBullet[i].y = player_y + 1;
                                    //한발씩 쏘겠다
                                    break;
                                }
                            }
                            for (int i = 0; i < playerBullet.Length; i++)
                            {
                                if (!playerBullet2[i].fire)
                                {
                                    playerBullet2[i].fire = true;
                                    playerBullet2[i].x = player_x + 5;
                                    playerBullet2[i].y = player_y;
                                    //한발씩 쏘겠다
                                    break;
                                }
                            }
                            for (int i = 0; i < playerBullet.Length; i++)
                            {
                                if (!playerBullet3[i].fire)
                                {
                                    playerBullet3[i].fire = true;
                                    playerBullet3[i].x = player_x + 5;
                                    playerBullet3[i].y = player_y + 2;
                                    //한발씩 쏘겠다
                                    break;
                                }
                            }
                            break;
                        }
                }

            }
        }
        //미사일 그리기
        public void BulletDraw()
        {
            string bullet = "->";
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet[i].fire)
                {
                    //좌표 설정 , 중간위치 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet[i].x - 1, playerBullet[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    playerBullet[i].x++;

                    if (playerBullet[i].x > 78)
                    {
                        playerBullet[i].fire = false; // 미사일 false 다시 준비상태
                    }
                }
            }
        }
        public void BulletDraw2()
        {
            string bullet = "->";
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet2[i].fire)
                {
                    //좌표 설정 , 중간위치 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet2[i].x - 1, playerBullet2[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    playerBullet2[i].x++;

                    if (playerBullet2[i].x > 78)
                    {
                        playerBullet2[i].fire = false; // 미사일 false 다시 준비상태
                    }
                }
            }
        }
        public void BulletDraw3()
        {
            string bullet = "->";
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet3[i].fire)
                {
                    //좌표 설정 , 중간위치 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet3[i].x - 1, playerBullet3[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    playerBullet3[i].x++;

                    if (playerBullet3[i].x > 78)
                    {
                        playerBullet3[i].fire = false; // 미사일 false 다시 준비상태
                    }
                }
            }
        }


        public void PlayerDraw()
        {
            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };

            for (int i = 0; i < player.Length; i++)
            {
                //콘솔좌표 설정
                Console.SetCursorPosition(player_x, player_y + i);
                //문자열 배열 출력
                Console.WriteLine(player[i]);
            }
        }
        //충돌 처리
        public void ClashEnemyAndBullet(Enemy enemy)
        {
            //미사일 20개
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire)
                {
                    //적과 y값이 같을때
                    if (playerBullet[i].y == enemy.Enemy_y)
                    {
                        if (playerBullet[i].x >= (enemy.Enemy_x - 1)
                            && playerBullet[i].x <= (enemy.Enemy_x + 1))
                        {

                            item.Item_Life = true;
                            item.Item_x = enemy.Enemy_x;
                            item.Item_y = enemy.Enemy_y;

                            Random random = new Random();
                            enemy.Enemy_x = 75;
                            enemy.Enemy_y = random.Next(2, 22);

                            playerBullet[i].fire = false;

                            Score += 100;
                        }
                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet2[i].fire)
                {
                    //적과 y값이 같을때
                    if (playerBullet2[i].y == enemy.Enemy_y)
                    {
                        if (playerBullet2[i].x >= (enemy.Enemy_x - 1)
                            && playerBullet2[i].x <= (enemy.Enemy_x + 1))
                        {
                            Random random = new Random();
                            enemy.Enemy_x = 75;
                            enemy.Enemy_y = random.Next(2, 22);

                            playerBullet2[i].fire = false;

                            Score += 100;
                        }
                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet3[i].fire)
                {
                    //적과 y값이 같을때
                    if (playerBullet3[i].y == enemy.Enemy_y)
                    {
                        if (playerBullet3[i].x >= (enemy.Enemy_x - 1)
                            && playerBullet3[i].x <= (enemy.Enemy_x + 1))
                        {
                            Random random = new Random();
                            enemy.Enemy_x = 75;
                            enemy.Enemy_y = random.Next(2, 22);

                            playerBullet3[i].fire = false;

                            Score += 100;
                        }
                    }
                }
            }
        }
        public void UIScore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        //아이템 충돌시 양쪽 미사일 발사
        public void CrashItem()
        {
            if (player_y + 1 == item.Item_y)
            {
                if (player_x >= item.Item_x - 2 && player_x <= item.Item_x + 2)
                {
                    item.Item_Life = false;

                    if(itemCount < 3)
                    {
                        itemCount++;
                    }
                    for(int i=0; i<20; i++)
                    {
                        playerBullet[i] = new BULLET();
                        playerBullet[i].x = 0;
                        playerBullet[i].y = 0;
                        playerBullet[i].fire = false;

                        playerBullet2[i] = new BULLET();
                        playerBullet2[i].x = 0;
                        playerBullet2[i].y = 0;
                        playerBullet2[i].fire = false;

                        playerBullet3[i] = new BULLET();
                        playerBullet3[i].x = 0;
                        playerBullet3[i].y = 0;
                        playerBullet3[i].fire = false;
                    }
                }
            }
        }



    }

    public class Enemy
    {
        public int Enemy_x;
        public int Enemy_y;

        public Enemy()
        {
            //적 좌표 초기화
            Enemy_x = 77;
            Enemy_y = 12;

        }

        public void EnemyDraw()
        {
            string enemy = "<-0->";
            Console.SetCursorPosition(Enemy_x, Enemy_y);
            Console.Write(enemy);
        }
        public void EnemyMove()
        {
            Random random = new Random();
            Enemy_x--;

            if (Enemy_x < 2)
            {
                Enemy_x = 77;
                Enemy_y = random.Next(2, 22);
            }
        }
    }
    public class ITEM
    {
        public string ItemName;
        public string Item_Sprite;
        public int Item_x;
        public int Item_y;
        public bool Item_Life = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(Item_x, Item_y);
            Item_Sprite = "Item★";
            Console.Write(Item_Sprite);
        }

        public void ItemMove()
        {
            //if(Item_x <=1 || Item_y <= 1)
            //{
            //    Item_Life = false;
            //}
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            //플레이어 생성
            PLAYER player = new PLAYER();
            Enemy enemy = new Enemy();
            // 유니티처럼 프레임속도
            int dwtime = Environment.TickCount; // 1/1000초가 흐른다

            while (true)
            {
                //0.05초 지연
                if (dwtime + 50 < Environment.TickCount)
                {
                    //현재 시간 세팅
                    dwtime = Environment.TickCount;
                    Console.Clear();
                    player.GameMain();

                    if(player.itemCount == 0)
                    {
                        player.BulletDraw();
                    }
                    else if(player.itemCount == 1)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                    }
                    else if (player.itemCount == 2)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();

                    }

                    enemy.EnemyMove();
                    enemy.EnemyDraw();

                    //충돌 처리
                    player.ClashEnemyAndBullet(enemy);

                }
            }


        }
    }
}
