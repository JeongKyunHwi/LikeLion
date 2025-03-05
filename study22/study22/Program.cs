using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study22
{

    //부모 클래스
    //class Animal
    //{
    //    public string Name { get; set; }
    //    public void Eat()
    //    {
    //        Console.WriteLine($"{Name}이(가) 음식을 먹고 있습니다.");
    //    }
    //}

    ////자식 클래스 (파생 클래스)
    //class Dog : Animal
    //{
    //    public void Bark()
    //    {
    //        Console.WriteLine($"{Name}이(가) 짖고 있습니다.");
    //    }
    //}

    //class Player
    //{
    //    public string name;

    //    public void Render()
    //    {
    //        Console.WriteLine($"플레이어 : {name}");
    //    }
    //}

    //class Wizard : Player
    //{
    //    public string job;


    //    public void Render2()
    //    {
    //        Console.WriteLine($"직업 : {job}");
    //    }
    //}

    //메서드 오버라이딩(overriding)
    //부모 클래스의 메서드를 자식 클래스에서 재정의하여 다른 동작을 수행할 수 있다.
    //public class Animal
    //{
    //    public string name { get; set; }
    //    public virtual void Speak()
    //    {
    //        Console.WriteLine("동물이 소리를 냅니다.");
    //    }
    //}
    //public class Dog : Animal
    //{
    //    public override void Speak()
    //    {
    //        Console.WriteLine($"{name}이(가) 멍멍 짖습니다.");
    //    }
    //}

    //업캐스팅(Upcasting)
    //자식 클래스에서 부모 클래스로 변환하는 것
    //암시적 변환이 가능 (컴파일러가 자동으로 변환)
    //안전: 데이터 손실 없이 변환가능
    //다운캐스팅
    //명시적변환이 필요(타입)
    //불완전함 -> 실행중 InvalidCastException 발생가능
    // is as 키워드로
    //public class Animal
    //{
    //    public string name;

    //    public void Speak()
    //    {
    //        Console.WriteLine("동물이 소리를 낸다.");
    //    }
    //}
    //public class Dog : Animal
    //{
    //    public void Bark()
    //    {
    //        Console.WriteLine("개가 짖는다.");
    //    }
    //}

    //public class Animal
    //{
    //    public virtual void Speak()
    //    {
    //        Console.WriteLine("동물이 소리냄.");
    //    }
    //}
    //public class Dog : Animal
    //{
    //    public override void Speak()
    //    {
    //        Console.WriteLine("멍멍");
    //    }

    //    public void WagTail()
    //    {
    //        Console.WriteLine("꼬리를 흔든다.");
    //    }
    //}
    
    //public class Parent
    //{
    //    public virtual void ShowMessage()
    //    {
    //        Console.WriteLine("부모 클래스의 메시지");
    //    }
    //}
    //public class Child : Parent
    //{
    //    public override void ShowMessage()
    //    {
    //        Console.WriteLine("자식 클래스의 메시지");
    //        base.ShowMessage(); // 부모 함수 실행
    //    }
    //}

    //public class Player
    //{
    //    protected string Name; // 부모 자식 상속관계에서만 사용하고 싶을때 protected

    //    public Player()
    //    {
    //        Name = "플레이어";
    //        Console.WriteLine("생성자입니다.");
    //    }

    //    public void Show()
    //    {
    //        Console.WriteLine(Name);
    //    }
    //}

    //public class Wizard : Player
    //{
    //    public Wizard()
    //    {
    //        Name = "마법사";
    //        Console.WriteLine("자식 생성자입니다.");
    //    }

    //}

    public class Unit
    {
        public string Name;
        public int Health;

        public Unit()
        {
            Name = "Unknown";
            Health = 0;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}이 기본 공격을 한다.");
        }
        public virtual void Heal(Unit target)
        {
            Console.WriteLine($"{Name}은(는) 치료할 수 없습니다.");
        }
        public virtual void Move()
        {
            Console.WriteLine($"{Name}이 이동합니다.");
        }
    }
    //scv 유닛은 건설과 수리기능
    public class SCV : Unit
    {
        public SCV()
        {
            Name = "SCV";
            Health = 60;
        }

        public override void Attack()
        {
            Console.WriteLine("SCV가 용접기로 공격합니다. (공격력이 약함)");
        }

        public override void Heal(Unit target)
        {
            Console.WriteLine($"SCV가 {target.Name}을(를) 수리합니다. (기계 유닛만 가능)");
        }
    }
    //marine (총기)
    public class Marine : Unit
    {
        public Marine()
        {
            Name = "Marine";
            Health = 40;
        }

        public override void Attack()
        {
            Console.WriteLine("Marine이 소총으로 공격합니다.");
        }

    }
    //Medic
    public class Medic : Unit
    {
        public Medic()
        {
            Name = "Medic";
            Health = 50;
        }
        public override void Heal(Unit target)
        {
            Console.WriteLine($"Medic이 {target.Name}을 치료합니다. (생명유닛만 가능)");
        }
    }

    //Tank
    public class Tank : Unit
    {
        public Tank()
        {
            Name = "Tank";
            Health = 150;
        }

        public override void Attack()
        {
            Console.WriteLine("Tank가 시즈 모드로 강력한 포격!");
        }

        public override void Move()
        {
            Console.WriteLine("Tank가 천천히 움직입니다.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>();

            units.Add(new SCV());
            units.Add(new Marine());
            units.Add(new Medic());
            units.Add(new Tank());

            //모든 유닛을 순회하며 다형성 적용
            foreach(var unit in units)
            {
                unit.Move();
                unit.Attack();
                Console.WriteLine();
                
            }

            SCV scv = new SCV();
            scv.Heal(units[3]);
            units[0].Heal(units[3]);

            Medic medic = new Medic();
            medic.Heal(units[1]);

            //Player p = new Player();
            //p.Show();

            //Wizard w = new Wizard();
            //w.Show();

            //Child child = new Child();
            //child.ShowMessage();


            //Animal animal = new Dog(); //업캐스팅

            //animal.Speak(); //멍멍 출력 오버라이드된 메서드 실행
            
            //Dog d = (Dog)animal;
            //d.WagTail();
            //Animal myanimal = new Animal();
            //myanimal.Speak();

            //Dog mydog = new Dog();
            //Animal myanimal = mydog; // 업캐스팅
            //myanimal.Speak();
            //Animal myanimal = new Dog();
            //Dog mydog = (Dog)myanimal; // 다운캐스팅
            //mydog.Bark();
            //mydog.Speak();
            
            //if(myanimal is Dog mydog1)
            //{
            //    mydog1.Bark();
            //}
            //else
            //{
            //    Console.WriteLine("변환할 수 없음.");
            //}

            //Dog mydog2 = myanimal as Dog;
            //if(mydog2 != null)
            //{
            //    mydog2.Bark();
            //}
            //else
            //{
            //    Console.WriteLine("변환할 수 없음.");
            //}

            //Animal myanimal2 = new Animal();
            //Dog mydog2 = (Dog)myanimal2;
            //mydog2.Speak(); //InvalidCastException 발생

            // myanimal.Bark();  오류, 업캐스팅 후 자식 클래스의 메서드 접근 불가



            //Animal myanimal = new Animal();
            //myanimal.name = "동물";
            //myanimal.Speak();

            //Dog mydog = new Dog();
            //mydog.name = "바둑";
            //mydog.Speak();

            //Player p = new Wizard();
            //p.name = "길동";
            //p.Render();
            

            //Wizard w = new Wizard();
            //w.job = "마법사";
            //w.name = "길종";
            //w.Render();
            //w.Render2();

            //Animal animal = new Animal();
            
            //Dog dog = new Dog();
            //dog.Name = "Bull";
            //dog.Eat();
            //dog.Bark();
        }
    }
}
