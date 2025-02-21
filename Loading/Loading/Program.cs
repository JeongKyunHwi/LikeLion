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

            //Console.Write("루인 스킬 피해를 입력하세요 : ");
            //string input = Console.ReadLine();
            //float skill_d = float.Parse(input);
            //Console.Write("카드 게이지 획득량을 입력하세요 : ");
            //input = Console.ReadLine();
            //float card_g = float.Parse(input);
            //Console.Write("각성기 피해를 입력하세요 : ");
            //input = Console.ReadLine();
            //float ult_d = float.Parse(input);
            //Console.Write("최대마나를 입력하세요 : ");
            //int maxMana = int.Parse(Console.ReadLine());
            //Console.Write("전투 중 마나 회복량을 입력하세요 : ");
            //int c_mana = int.Parse(Console.ReadLine());
            //Console.Write("비전투중 마나 회복량을 입력하세요 : ");
            //int nc_mana = int.Parse(Console.ReadLine());
            //Console.Write("이동속도를 입력하세요 : ");
            //float moveSpeed = float.Parse(Console.ReadLine());
            //Console.Write("탈 것 속도를 입력하세요 : ");
            //float horseSpeed = float.Parse(Console.ReadLine());
            //Console.Write("운반속도를 입력하세요 : ");
            //float carrySpeed = float.Parse(Console.ReadLine());
            //Console.Write("스킬 재사용 대기시간 감소량을 입력하세요 : ");
            //float cooldown = float.Parse(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine($"루인 스킬 피해 :{skill_d}%");
            //Console.WriteLine($"카드 게이지 획득량 :{card_g}%");
            //Console.WriteLine($"각성기 피해 :{ult_d}%");
            //Console.WriteLine($"최대마나 :{maxMana} ");
            //Console.WriteLine($"전투 중 마나 회복량 :{c_mana} ");
            //Console.WriteLine($"비전투 중 마나 회복량 :{nc_mana} ");
            //Console.WriteLine($"이동속도 :{moveSpeed}%");
            //Console.WriteLine($"탈 것 속도 :{horseSpeed:F1}%");
            //Console.WriteLine($"운반속도 :{carrySpeed:F1}%");
            //Console.WriteLine($"스킬 재사용 대기시간 감소량 :{cooldown}%");

            //로딩바 , 시작화면
            //게임스토리1
            //□ ■
            Thread.Sleep(5000);
            Console.Write("□□□□□□□□□□");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("■□□□□□□□□□");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("■■□□□□□□□□");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("■■■□□□□□□□");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("■■■■□□□□□□");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("■■■■■□□□□□");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("■■■■■■□□□□");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("■■■■■■■□□□");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("■■■■■■■■□□");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("■■■■■■■■■□");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("■■■■■■■■■■");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("로딩 완료. 엔터를 입력하여 게임 시작");
            Console.ReadLine();
            Console.Clear();
            string userName;

            Console.WriteLine("오스카네 대륙 모험기");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("먼 옛날 신들의 전쟁이후, 행성 다일레스에 혼돈과 어둠의 신 오스쿠로의 육체가 봉인되었다.");
            Thread.Sleep(2000);
            Console.WriteLine("오스쿠로의 육체는 다일레스 행성의 오스카네 대륙에 봉인되었지만, 오랜 시간이 흘러 봉인이 약해졌다.");
            Thread.Sleep(2000);
            Console.WriteLine("그로 인해 다일레스 행성에는 혼돈과 어둠의 힘으로 점차 침식되어 가고 있다.");
            Thread.Sleep(2000);
            Console.WriteLine("엔터를 입력하여 계속...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("각 대륙에서는 오스카네 대륙을 정화하기 위해 모험가들을 파견하여 원인을 조사하려고 한다.");
            Thread.Sleep(2000);
            Console.WriteLine("나도 어엿한 모험가가 되어 원인 조사에 참여하고 동료들을 모아 재밌는 모험을 하고싶다.");
            Thread.Sleep(2000);
            Console.WriteLine("그러기 위해서는 우선 모험가 길드로 가서 동료를 찾아보자!");
            Thread.Sleep(2000);
            Console.WriteLine("엔터를 입력하여 계속...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("<모험가 길드>");
            Console.Write("안내원 : 안녕하세요 모험가님! 오늘 처음보는 얼굴이네요! 길드에 등록하시나요? 여기에 이름을 적어주세요. ");
            userName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("<모험가 길드>");
            Console.WriteLine($"안내원 : 네 {userName}님, 정식으로 저희 길드에 등록되셨습니다. 혹시 동료를 찾으시고 있다면 저기 모집 게시판으로 가주세요!" );

            Thread.Sleep(5000);
            Console.Clear();

            Console.WriteLine("<모집 게시판 앞>");
            Thread.Sleep(2000);
            Console.WriteLine($"{userName} : 어떤 동료와 함께해야 할까?");
            Thread.Sleep(2000);
            Console.WriteLine("게시판에는 여러 사람의 등급과 직업, 사진이 붙어있는 종이가 여러 장 걸려있다.");
            Thread.Sleep(2000);
            Console.WriteLine("그 중에서 눈에 띄는 몇개가 보인다. 치유사, 마법사, 전사, 무도가 등등");
            Thread.Sleep(2000);
            Console.WriteLine($"{userName}은(는) 종이들을 몇개 챙겼다.");
            Thread.Sleep(2000);
            Console.WriteLine($"{userName}은(는) 그렇게 동료를 모집하러 모험가 길드 밖으로 나섰다.");
            Console.WriteLine("다음화에 계속...");


        }
    }
}
