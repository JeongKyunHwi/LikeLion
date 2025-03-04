using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ShootingGame
{
    public class Bullet
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsFired { get; set; }

        public Bullet() => Reset();
        public void Reset() { X = 0; Y = 0; IsFired = false; }
    }

    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();

        public int X { get; private set; } = 0;
        public int Y { get; private set; } = 12;
        public int Score { get; private set; } = 100;
        public int ItemCount { get; private set; } = 0;
        public Item Item { get; private set; } = new Item();
        private List<Bullet> bullets = new List<Bullet>();

        public Player()
        {
            for (int i = 0; i < 60; i++) bullets.Add(new Bullet());
        }

        public void GameMain()
        {
            KeyControl();
            Draw();
            UIScore();
            if (Item.IsActive) { Item.Move(); Item.Draw(); CheckItemCollision(); }
        }

        private void KeyControl()
        {
            if (!Console.KeyAvailable) return;
            int key = _getch();

            switch (key)
            {
                case 72: Y = Math.Max(1, Y - 1); break;
                case 75: X = Math.Max(0, X - 1); break;
                case 77: X = Math.Min(75, X + 1); break;
                case 80: Y = Math.Min(22, Y + 1); break;
                case 32: FireBullet(); break;
            }
        }

        private void FireBullet()
        {
            for (int i = 0; i < (ItemCount + 1) * 20; i++)
            {
                if (!bullets[i].IsFired)
                {
                    bullets[i].IsFired = true;
                    bullets[i].X = X + 5;
                    bullets[i].Y = Y + (i % 3 - 1);
                    break;
                }
            }
        }

        public void DrawBullets()
        {
            foreach (var bullet in bullets)
            {
                if (!bullet.IsFired) continue;
                Console.SetCursorPosition(bullet.X - 1, bullet.Y);
                Console.Write("->");
                bullet.X++;
                if (bullet.X > 78) bullet.Reset();
            }
        }

        public void Draw()
        {
            string[] sprite = { "->", ">>>", "->" };
            for (int i = 0; i < sprite.Length; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                Console.WriteLine(sprite[i]);
            }
        }

        public void CheckBulletCollision(Enemy enemy)
        {
            foreach (var bullet in bullets)
            {
                if (bullet.IsFired && bullet.Y == enemy.Y && bullet.X >= enemy.X - 1 && bullet.X <= enemy.X + 1)
                {
                    Item.Activate(enemy.X, enemy.Y);
                    enemy.ResetPosition();
                    bullet.Reset();
                    Score += 100;
                }
            }
        }

        private void UIScore()
        {
            Console.SetCursorPosition(63, 0);
            Console.WriteLine("Score: " + Score);
        }

        private void CheckItemCollision()
        {
            if (Y + 1 == Item.Y && X >= Item.X - 2 && X <= Item.X + 2)
            {
                Item.IsActive = false;
                if (ItemCount < 3) ItemCount++;
                foreach (var bullet in bullets) bullet.Reset();
            }
        }
    }

    public class Enemy
    {
        public int X { get; private set; } = 77;
        public int Y { get; private set; } = 12;
        private Random random = new Random();

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("<-0->");
        }

        public void Move()
        {
            X--;
            if (X < 2) ResetPosition();
        }

        public void ResetPosition()
        {
            X = 77;
            Y = random.Next(2, 22);
        }
    }

    public class Item
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public bool IsActive { get; set; }

        public void Activate(int x, int y)
        {
            X = x;
            Y = y;
            IsActive = true;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("Item★");
        }

        public void Move() { /* 이동 로직 추가 가능 */ }
    }

    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Player player = new Player();
            Enemy enemy = new Enemy();
            int frameTime = Environment.TickCount;

            while (true)
            {
                if (frameTime + 50 < Environment.TickCount)
                {
                    frameTime = Environment.TickCount;
                    Console.Clear();
                    player.GameMain();
                    player.DrawBullets();
                    enemy.Move();
                    enemy.Draw();
                    player.CheckBulletCollision(enemy);
                }
            }
        }
    }
}
