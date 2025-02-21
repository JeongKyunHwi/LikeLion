using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loading
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("□□□□□□□□□□");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("■□□□□□□□□□");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("■■□□□□□□□□");
            //Console.Clear();

            //Console.Write("이름을 입력하세요 : ");
            //string userName = Console.ReadLine();

            //Console.WriteLine($"안녕하세요 {userName}님!");
            //Console.Write("나이를 입력하세요 : ");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);

            //Console.WriteLine($"내년에는 {age + 1} 살이 되시겠네요");
            //Console.WriteLine("내년에는 {0} 살이 되시겠네요", age);

            Console.Write("루인 스킬 피해를 입력하세요 : ");
            string input = Console.ReadLine();
            float skill_d = float.Parse(input);
            Console.Write("카드 게이지 획득량을 입력하세요 : ");
            input = Console.ReadLine();
            float card_g = float.Parse(input);
            Console.Write("각성기 피해를 입력하세요 : ");
            input = Console.ReadLine();
            float ult_d = float.Parse(input);
            Console.Write("최대마나를 입력하세요 : ");
            int maxMana = int.Parse(Console.ReadLine());
            Console.Write("전투 중 마나 회복량을 입력하세요 : ");
            int c_mana = int.Parse(Console.ReadLine());
            Console.Write("비전투중 마나 회복량을 입력하세요 : ");
            int nc_mana = int.Parse(Console.ReadLine());
            Console.Write("이동속도를 입력하세요 : ");
            float moveSpeed = float.Parse(Console.ReadLine());
            Console.Write("탈 것 속도를 입력하세요 : ");
            float horseSpeed = float.Parse(Console.ReadLine());
            Console.Write("운반속도를 입력하세요 : ");
            float carrySpeed = float.Parse(Console.ReadLine());
            Console.Write("스킬 재사용 대기시간 감소량을 입력하세요 : ");
            float cooldown = float.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"루인 스킬 피해 :{skill_d}%");
            Console.WriteLine($"카드 게이지 획득량 :{card_g}%");
            Console.WriteLine($"각성기 피해 :{ult_d}%");
            Console.WriteLine($"최대마나 :{maxMana} ");
            Console.WriteLine($"전투 중 마나 회복량 :{c_mana} ");
            Console.WriteLine($"비전투 중 마나 회복량 :{nc_mana} ");
            Console.WriteLine($"이동속도 :{moveSpeed}%");
            Console.WriteLine($"탈 것 속도 :{horseSpeed:F1}%");
            Console.WriteLine($"운반속도 :{carrySpeed:F1}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소량 :{cooldown}%");
            


        }
    }
}
