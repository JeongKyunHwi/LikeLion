using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        //최대 아이템 개수 (배열 크기)
        const int MAX_ITEMS = 10;

        //아이템 배열 (이름 저장)
        static string[] item_Names = new string[MAX_ITEMS];
        static int[] item_Counts = new int[MAX_ITEMS];

        //아이템 추가 함수
        static void Add_Item(string name, int count)
        {
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (item_Names[i] == name)
                { //이미 있는 아이템이면 개수 증가
                    item_Counts[i] += count;
                    return;
                }
            }

            //빈 슬롯에 아이템 추가
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (item_Names[i] == null)
                {
                    item_Names[i] = name;
                    item_Counts[i] = count;
                    return;
                }
            }
            Console.WriteLine("인벤토리가 가득 찼습니다.");
        }

        //아이템 제거 함수
        static void Delete_Item(string name, int count)
        {
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (item_Names[i] == name)
                {
                    if (item_Counts[i] >= count)
                    {
                        item_Counts[i] -= count;
                        if (item_Counts[i] == 0)
                        {
                            item_Names[i] = null;
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("아이템 갯수가 부족합니다.");
                        return;
                    }


                }
            }
            Console.WriteLine("아이템을 찾을 수 없습니다.");
        }

        static void Show_Inventory()
        {
            Console.WriteLine("현재 인벤토리 : ");
            bool is_Empty = true;

            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (item_Names[i] != null)
                {
                    Console.Write($"{item_Names[i]} x({item_Counts[i]})\n");
                    is_Empty = false;
                }
            }
            if (is_Empty)
            {
                Console.WriteLine("인벤토리가 비어있습니다.");
            }
        }


        static void Main(string[] args)
        {
            Add_Item("포션", 5);
            Add_Item("칼", 1);
            Add_Item("포션", 3);

            Show_Inventory();

            //아이템 사용
            Console.WriteLine("포션 2개 사용");
            Delete_Item("포션", 2);
            Show_Inventory();

            //테스트 : 없는 아이템 제거
            Console.WriteLine("방패 1개 제거 시도");
            Delete_Item("방패", 1);

            Show_Inventory();


            //테스트: 모든 포션 제거
            Console.WriteLine("포션 6개 사용(초과 사용 테스트)");
            Delete_Item("포션", 6);
            Show_Inventory();
        }
    }
}
