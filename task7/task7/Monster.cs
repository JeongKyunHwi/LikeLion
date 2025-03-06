using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Monster
    {
        public INFO Monster_Info = null;

        public void Set_Monster_Info(INFO m_info)
        {
            Monster_Info = m_info;
        }
        public INFO Get_Moster_Info()
        {
            return Monster_Info;
        }
        public void Set_Damage(int damage)
        {
            Monster_Info.Hp -= damage;
        }
        public void Render()
        {
            Console.WriteLine("=============");
            Console.WriteLine($"몬스터 이름: {Monster_Info.Name}");
            Console.WriteLine($"체력: {Monster_Info.Hp} \t 공격력: {Monster_Info.Attack}");

        }
    }
}
