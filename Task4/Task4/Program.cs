using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        const int MAX_ITEMS = 10;

        struct Inventory
        {
            public string[] Item_Name;
            public int[] Item_Count;

            public Inventory(int a)
            {
                Item_Name = new string[a];
                Item_Count = new int[a];
            }
            public void Add_Item(string s, int c)
            {
                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (Item_Name[i] == s)
                    {
                        Item_Count[i] += c;
                        return;
                    }

                }
                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (Item_Name[i] == null)
                    {
                        Item_Name[i] = s;
                        Item_Count[i] = c;
                        return;
                    }
                }
                Console.WriteLine("인벤토리 가득 참");
            }
            public void Delete_Item(string s, int c)
            {
                Console.WriteLine($"{s} {c}개 삭제 시도");
                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (Item_Name[i] == s)
                    {
                        if (Item_Count[i] >= c)
                        {
                            Item_Count[i] -= c;
                            if (Item_Count[i] == 0)
                            {
                                Item_Name[i] = null;
                            }
                            return;
                        }
                        else if (Item_Count[i] - c < 0)
                        {
                            Console.WriteLine($"소지한 {Item_Name[i]}의 개수가 부족합니다.");
                            return;
                        }
                    }
                }
                Console.WriteLine($"{s}는 인벤토리에 없습니다.");
            }
            public void Show_Inventory()
            {
                bool is_Empty = true;
                Console.WriteLine("현재 인벤토리");
                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (Item_Name[i] != null)
                    {
                        Console.Write($"{Item_Name[i]} x({Item_Count[i]})\n");
                        is_Empty = false;
                    }

                }
                if (is_Empty)
                {
                    Console.WriteLine("인벤토리가 비어있음.");
                }

            }
        }


        static void Main(string[] args)
        {
            Inventory inventories = new Inventory(MAX_ITEMS);
            inventories.Add_Item("포션", 3);
            inventories.Add_Item("포션", 3);
            inventories.Add_Item("칼", 1);
            inventories.Show_Inventory();
            inventories.Delete_Item("포션", 3);
            inventories.Show_Inventory();
            inventories.Delete_Item("칼", 2);
            inventories.Show_Inventory();
            inventories.Delete_Item("칼", 1);
            inventories.Show_Inventory();
            inventories.Delete_Item("방패", 1);
            inventories.Show_Inventory();


        }
    }
}
