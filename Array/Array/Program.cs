using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        public static void swap(int a, int b)
        {
            //int a = 10;
            //int b = 20;
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            //int[] num = new int[3];

            //num[0] = 10;
            //num[1] = 20;
            //num[2] = 30;
            //for(int i =0; i<3; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            //int[] numbers = { 1, 2, 3 };
            //int[] numbers1 = new int[3];
            //int[] numbers2 = new int[] { 1, 2, 3 };

            //string[] fruits = { "사과", "바나나", "포도" };


            //for(int i = 0; i<3; i++)
            //{
            //    Console.WriteLine("numbers : " + numbers[i]);
            //    Console.WriteLine("numbers1 : " + numbers1[i]);
            //    Console.WriteLine("numbers2 : " + numbers2[i]);
            //    Console.WriteLine(fruits[i]);

            //}

            //3명의 점수를 입력받고 총점과 평균을 출력
            //국어 영어 수학 점수 
            //int[] kor = new int[3];
            //int[] eng = new int[3];
            //int[] math = new int[3];

            //int[] sum = new int[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("국어 점수를 입력 : ");
            //    kor[i] = int.Parse(Console.ReadLine());
            //    Console.Write("영어 점수를 입력 : ");
            //    eng[i] = int.Parse(Console.ReadLine());
            //    Console.Write("수학 점수를 입력 : ");
            //    math[i] = int.Parse(Console.ReadLine());
            //}
            //sum[0] = kor[0] + kor[1] + kor[2];
            //sum[1] = eng[0] + eng[1] + eng[2];
            //sum[2] = math[0] + math[1] + math[2];

            //Console.WriteLine("국어 총점 : " + sum[0]);
            //Console.WriteLine("영어 총점 : " + sum[1]);
            //Console.WriteLine("수학 총점 : " + sum[2]);
            //Console.WriteLine("국어 평균 : " + ((float)sum[0] / 3).ToString("F2"));
            //Console.WriteLine("영어 평균 : " + ((float)sum[1] / 3).ToString("F2"));
            //Console.WriteLine("수학 평균 : " + ((float)sum[2] / 3).ToString("F2"));

            //int[] scores = new int[3];
            //scores[0] = 90;
            //scores[1] = 85;
            //scores[2] = 88;

            //for(int i = 0; i<scores.Length; i++)
            //{
            //    Console.WriteLine($"점수 {i + 1} : {scores[i]}");
            //}

            //double value = 1234.56789;
            ////소수점 자리수 설정
            //Console.WriteLine(value.ToString("F2"));
            //Console.WriteLine($"소수점 둘쨰자리 : {value:F2}");
            //Console.WriteLine(String.Format("소수점 둘째자리: {0:F2}",value));

            //double v = 2315452154.12321;
            //Console.WriteLine(v.ToString("N2")); //3자리 마다 쉼표넣기

            //int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            //for(int i = 0; i<2; i++)
            //{
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(matrix[i, j]);
            //    }
            //}

            //int[][] matrix = new int[2][];

            //matrix[0] = new int[3];
            //matrix[1] = new int[3];

            //matrix[0][0] = 1;
            //matrix[0][1] = 2;
            //matrix[0][2] = 3;
            //matrix[1][0] = 4;
            //matrix[1][1] = 5;
            //matrix[1][2] = 6;

            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    for (int j = 0; j < matrix[i].Length; j++)
            //    {
            //        Console.WriteLine(matrix[i][j]);
            //    }
            //}

            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[] { 1, 2 };
            //jaggedArray[1] = new int[] { 3, 4, 5 };
            //jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            //for(int i = 0; i<jaggedArray.Length; i++)
            //{
            //    for(int j=0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.WriteLine(jaggedArray[i][j]);
            //    }
            //}
            //var numbers = new[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"배열 타입: {numbers.GetType()}");

            int[] iArray = new int[25];

            int a = 10;
            int b = 20;
            int temp = 0;
            temp = a;
            a = b;
            b = temp;

            for (int i = 0; i < 25; i++)
            {
                iArray[i] = i + 1;
            }


            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                int iA = random.Next(0, 25);
                int iB = random.Next(0, 25);
                int it = 0;
                it = iArray[iA];
                iArray[iA] = iArray[iB];
                iArray[iB] = it;
            }

            int input = 0;
            int iBingo = 0;
            int iCount = 0;

            while (true)
            {

                Console.Clear();
                
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (iArray[i * 5 + j] == 0)
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("iBingo: " + iBingo);
                

                Console.WriteLine("숫자를 입력하세요.");
                input = int.Parse(Console.ReadLine());
                iBingo = 0;

                for (int i = 0; i < iArray.Length; i++)
                {
                    if (iArray[i] == input)
                    {
                        iArray[i] = 0;
                        break;
                    }
                }

                for (int i = 0; i < 5; ++i)
                {
                    for (int j = 0; j < 5; ++j)
                    {
                        if (iArray[i * 5 + j] == 0)
                        {
                            ++iCount;
                        }

                        if (iCount == 5)
                        {
                            ++iBingo;
                        }
                    }
                    iCount = 0;
                }

                //세로 체크
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (iArray[i + 5 * j] == 0)
                        {
                            ++iCount;
                        }

                        if (iCount == 5)
                        {
                            ++iBingo;
                        }
                    }
                    iCount = 0;
                }



                //대각선 오른쪽체크
                //00 01 02 03 04
                //05 06 07 08 09
                //10 11 12 13 14
                //15 16 17 18 19
                //20 21 22 23 24

                for (int i = 0; i < 5; i++)
                {
                    if (iArray[i * 4 + 4] == 0)
                    {
                        ++iCount;
                    }

                    if (iCount == 5)
                    {
                        ++iBingo;
                    }
                }
                iCount = 0;







                //대각선 왼쪽체크
                //00 01 02 03 04
                //05 06 07 08 09
                //10 11 12 13 14
                //15 16 17 18 19
                //20 21 22 23 24
                for (int i = 0; i < 5; i++)
                {
                    if (iArray[i * 6] == 0)
                    {
                        ++iCount;
                    }

                    if (iCount == 5)
                    {
                        ++iBingo;
                    }
                }
                iCount = 0;


                if (iBingo >= 5)
                {
                    Console.WriteLine("빙고 성공");
                    break;
                }
            }





        }
    }
}
