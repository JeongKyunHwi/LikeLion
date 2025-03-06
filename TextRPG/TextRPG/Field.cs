using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Field
    {
        Player m_pPlayer = null;
        //몬스터
        Monster m_pMonster = null;

        //MainGame에서 생성한 플레이어 가져오기
        //플레이어가 필드에서 전투를 하면, 데미지를 입을거고 hp가 깎이겠네
        //ref? 
        public void SetPlayer(Player pPlayer) { m_pPlayer = pPlayer; }

        public void Progress()
        {
            //사냥터로 들어왔다.
            int iInput = 0;
            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                DrawMap();
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4) break;
                if (iInput <= 3)
                {
                    //몬스터 만들고
                    //1번일때 초보몬스터
                    //2번일때 중급몬스터
                    //3번일때 고급몬스터
                    CreateMonster(iInput);
                    //싸운다
                    Fight();
                }
            }


        }
        //생성을 도와주는 함수
        //팩토리 메서드 패턴
        public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster();
            INFO tMonster = new INFO();

            tMonster.strName = _strName;
            tMonster.iHp = _iHp;
            tMonster.iAttack = _iAttack;

            pMonster.SetMonster(tMonster);
        }

        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    //공장처럼 찍어낸다.
                    //디자인 패턴 팩토리 메서드 패턴
                    Create("초보몹", 30, 3, out m_pMonster);
                    break;
                case 2:
                    Create("중수몹", 60, 6, out m_pMonster);
                    break;
                case 3:
                    Create("고수몹", 90, 9, out m_pMonster);
                    break;
            }
        }

        public void Fight()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                m_pMonster.Render();

                Console.WriteLine("1. 공격 2. 도망");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 1)
                {
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    m_pMonster.SetDamage(m_pPlayer.GetInfo().iAttack);

                    if (m_pPlayer.GetInfo().iHp <= 0)// 플레이어 체력 0 이하
                    {
                        if (m_pPlayer.GetInfo().strName == "기사")
                        {
                            m_pPlayer.SetHp(100);
                            break;
                        }
                        else if (m_pPlayer.GetInfo().strName == "마법사")
                        {
                            m_pPlayer.SetHp(90);
                            break;
                        }
                        else
                        {
                            m_pPlayer.SetHp(85);
                            break;
                        }

                        
                    }

                }
                if (iInput == 2 || m_pMonster.GetMonster().iHp <= 0)
                {
                    m_pMonster = null;
                    break;
                }
            }
        }

        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("===============");
            Console.WriteLine("맵을 선택하세요 : ");
        }

    }
}
