using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[5, 5];
            bool[,] marked = new bool[5, 5];

            int BingoCount = 0;
            Random random = new Random();

            int[] numbers = new int[25];
            for (int i = 0; i < 25; i++)
            {
                numbers[i] = i + 1;
            }

            //Fisher-Yates Shuffle
            for (int i = 0; i < 100; i++)
            {
                int a = random.Next(25);
                int b = random.Next(25);

                //C#의 튜플(Tuple) 문법을 활용하여 두 변수의 값을 교환(Swap)하는 방법
                (numbers[a], numbers[b]) = (numbers[b], numbers[a]);
            }
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    board[i, j] = numbers[index++];
                }
            }

            while (BingoCount < 5)
            {
                Console.Clear();

                Console.WriteLine("현재 빙고판");

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (marked[i, j])
                        {
                            Console.Write(" X ");
                        }
                        else
                        {
                            Console.Write($"{board[i, j],2} ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"현재 빙고 개수: {BingoCount}");
                Console.WriteLine("숫자를 입력하세요(1~25)");
                int number = int.Parse(Console.ReadLine());
                //숫자 입력

                bool found = false;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (board[i, j] == number)
                        {
                            marked[i, j] = true;
                            found = true;
                            break;
                        }
                    }
                    if (found) break;
                }

                BingoCount = 0;

                for (int i = 0; i < 5; i++)
                {
                    bool rowBingo = true;
                    for (int j = 0; j < 5; j++)
                    {
                        if (!marked[i, j]) rowBingo = false;
                    }
                    if (rowBingo) BingoCount++;
                }
                for (int j = 0; j < 5; j++)
                {
                    bool colBingo = true;

                    for (int i = 0; i < 5; i++)
                        if (!marked[i, j]) colBingo = false;

                    if (colBingo) BingoCount++;
                }
                bool check1 = true;
                for (int i = 0; i < 5; i++)
                {
                    if (!marked[i, i]) check1 = false;
                }
                if (check1) BingoCount++;

                bool check2 = true;

                for (int i = 0; i < 5; i++)
                {
                    if (!marked[i, 4-i]) check2 = false;
                }
                if (check2) BingoCount++;
            }

        }
    }
}
