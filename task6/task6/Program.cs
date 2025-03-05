using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{

    class Champ
    {
        public string Name;
        public int Health;
        public Champ()
        {
            Name = "";
            Health = 0;
        }


        public void Status()
        {
            Console.WriteLine($"챔피언 이름: {Name}, 체력: {Health}");
        }
        public virtual void Move()
        {
            Console.WriteLine($"{Name}은 움직였다.");
        }
        public virtual void Attack()
        {
            Console.WriteLine($"{Name}은 공격했다.");
        }
        public virtual void Flash()
        {
            Console.WriteLine($"{Name}은 점멸을 사용했다.");
        }
        public virtual void Use_Q_Skill()
        {
            Console.Write("Q스킬 \t");
        }
    }
    class Garen : Champ
    {
        public Garen()
        {
            Name = "Garen";
            Health = 600;
        }
        public override void Attack()
        {
            Console.WriteLine($"{Name}이 대검으로 공격합니다.");
        }

        public override void Use_Q_Skill()
        {
            base.Use_Q_Skill();
            Console.WriteLine("결정타 사용!");
        }
    }
    class Galio : Champ
    {
        public Galio()
        {
            Name = "Galio";
            Health = 580;
        }
        public override void Attack()
        {
            Console.WriteLine($"{Name}이 주먹으로 공격합니다.");
        }
        public override void Use_Q_Skill()
        {
            base.Use_Q_Skill();
            Console.WriteLine("전장의 돌풍 사용!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Champ> list = new List<Champ>();
            list.Add(new Garen());
            list.Add(new Galio());

            for (int i = 0; i < list.Count; i++)
            {
                list[i].Status();
                list[i].Move();
                list[i].Attack();
                list[i].Flash();
                list[i].Use_Q_Skill();
                Console.WriteLine();
            }
        }
    }
}
