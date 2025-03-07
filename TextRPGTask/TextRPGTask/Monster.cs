using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGTask
{
    public class Monster
    {
        public string Name;
        public int Hp;
        public int Att;

        public void Render()
        {
            Console.WriteLine("=================");
            Console.WriteLine($"몬스터 : {Name}");
            Console.WriteLine($"체력 : {Hp} \t 공격력 : {Att}");
        }
    }

}
