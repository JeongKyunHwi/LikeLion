using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HELLO;

namespace HELLO{
    class SAY
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
namespace study23
{
    //class Person
    //{
    //    private string name;
    //    public void setname(string n)
    //    {
    //        name = n;
    //    }
    //    public string getname()
    //    {
    //        return name;
    //    }


    //}
    class MyResource
    {
        ~MyResource()
        {
            Console.WriteLine("삭제될 때 호출");
        }
    }
    class Program
    {
        //static void Increase(ref int x)
        //{
        //    x++;
        //}

        ////out은 반환이 여러개일 때 유용하다.
        //static void OutFunc(int a, int b, out int x, out int y)
        //{
        //    x = a;
        //    y = b;
        //}
        
        //추상클래스 (Abstract Class)
        //추상클래스는 객체를 생성할 수 없는 클래스로, 상속을 통해서만 사용할 수 있다.
        //공통적인 기능을 정의하고, 상속받은 클래스가 이를 구현하도록 강제할 때 사용.
        //abstract 키워드 사용
        //추상 메서드는 선언만 하고 구현하지 않는다.
        //상속받은 클래스는 반드시 구현해야한다.

        abstract class Animal
        {
            //추상 메서드 (구현하지 않음)
            public abstract void MakeSound();
            //일반 메서드 (공통 기능 제공)
            public void Sleep()
            {
                Console.WriteLine("동물이 잠을 잔다.");
            }

        }
        //추상클래스를 상속받아 구체적인 클래스 구현
        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("멍멍");
            }
        }
        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("야옹");
            }
        }

        //class Parent
        //{

        //    public Parent(string message)
        //    {
        //        Console.WriteLine("부모 생성자"+message);
        //    }
        //}
        //class Child : Parent
        //{
        //    public Child() : base("성공")
        //    {
        //        Console.WriteLine("자식 생성자");
        //    }

        //}
        //class Parent
        //{
        //    protected string name;

        //    public Parent(string name)
        //    {
        //        this.name = name;
        //        Console.WriteLine($"부모 생성자: {name}");
        //    }
        //}
        //class Child : Parent
        //{
        //    private int age;
        //    //부모 생성자를 호출하면서 name을 전달+ 추가로 age 초기화
        //    public Child(string name,int age):base(name)
        //    {
        //        this.age = age;
        //        Console.WriteLine($"자식 생성자: {age}");
        //    }

        //    public void Show()
        //    {
        //        Console.WriteLine($"이름 : {name}, 나이: {age}");
        //    }
        //}




        static void Main(string[] args)
        {
            //HELLO.SAY say = new HELLO.SAY();
            //say.SayHello();
            //SAY say = new SAY();
            //say.SayHello();
            //Person p = new Person();
            //p.setname("Bob");
            //Console.WriteLine(p.getname());
            //MyResource myResource = new MyResource();
            //GC에의해 나중에 소멸자 호출

            //int a = 10;
            //int b = 20;
            //int x, y;
            ////int a = 10;
            ////Increase(ref a);

            //OutFunc(a, b, out x, out y);
            //Console.WriteLine($"{x}, {y}");
            //Animal myanimal = new Dog();
            //Animal mycat = new Cat();
            //myanimal.MakeSound();
            //myanimal.Sleep();
            //mycat.MakeSound();
            //mycat.Sleep();
            //Child child = new Child();
            //Child child = new Child("길동", 25);

            //child.Show();

            Console.WriteLine("간단한 RPG 게임을 시작합니다.");

            //캐릭터 생성
            GameCharacter warrior = new Warrior("전사");
            GameCharacter mage = new Mage("법사");

            //전투 시뮬
            Console.WriteLine("======전투 시작!======");

            //전사의 공격
            warrior.BasicAttack(mage);
            warrior.SpecialAttack(mage);

            //마법사 반격
            mage.BasicAttack(warrior);
            mage.SpecialAttack(warrior);

            Console.WriteLine("======전투 종료!======");
            Console.WriteLine($"전사의 남은 체력 : {warrior.Health}");
            Console.WriteLine($"법사의 남은 체력 : {mage.Health}");


        }
    }
}
