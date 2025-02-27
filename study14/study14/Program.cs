using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study14
{
    class Program
    {
        enum DayofWeek
        {
            Sunday, //0
            Monday, //1
            Tuesday, //2
            Wednesday, //3
            Thursday,
            Friday,
            Saturday
        }

        enum StatusCode
        {
            Success = 200,
            BadRequest = 400,
            Unauthorized = 401,
            NotFound = 404
        }

        enum WeaponType
        {
            Sword = 0,
            Bow = 1,
            Staff = 2
        }
        static void ChooseWeapon(WeaponType a)
        {
            if (a == WeaponType.Sword)
            {
                Console.WriteLine("검을 선택하셨습니다.");
            }else if (a == WeaponType.Bow)
            {
                Console.WriteLine("활을 선택하셨습니다.");
            }
            else
            {
                Console.WriteLine("지팡이를 선택하셨습니다.");
            }
        }

        struct Point
        {
            public int X;
            public int Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void Print()
            {
                Console.WriteLine($"좌표 : {X} , {Y}");
            }

        }

        struct Rectangle
        {
            public int width;
            public int height;


            public int GetArea() => width * height;
        }

        static void Main(string[] args)
        {

            //var rect = new Rectangle { width = 5, height = 10 };
            //Rectangle rect;
            //Rectangle rect = new Rectangle();
            //rect.width = 5;
            //rect.height = 10;
            //Console.WriteLine(rect.GetArea());
            //Point p;
            //p.X= 5;
            //p.Y = 10;
            //p.Print();
            //Point p1 = new Point(5, 16);
            //p1.Print();
            

            //WeaponType wt = WeaponType.Sword;
            //ChooseWeapon(wt);
            //wt = WeaponType.Bow;
            //ChooseWeapon(wt);
            //wt = WeaponType.Staff;
            //ChooseWeapon(wt);

            //DayofWeek today = DayofWeek.Wednesday;
            //Console.WriteLine(today);
            //Console.WriteLine((int)today);
            //StatusCode status = StatusCode.NotFound;

            //Console.WriteLine(status);
            //Console.WriteLine((int)status);
        }
    }
}
