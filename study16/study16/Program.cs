using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study16
{
    //마린 클래스
    //이름 , 미네랄 
    //기본 생성자, 인자 있는 생성자
    class Marine
    {
        public string Name;
        public int Mineral;
        public Marine()
        {
            Name = "";
            Mineral = 50;
            Console.WriteLine($"기본 생성자 호출, 이름 : {Name}, 미네랄: {Mineral}");
        }
        public Marine(string name , int mineral)
        {
            Name = name;
            Mineral = mineral;
            Console.WriteLine($"인자있는 생성자 호출, 이름 : {Name}, 미네랄: {Mineral}");
        }
    }
    class SCV
    {
        public string Name;
        public int Mineral;
        public SCV()
        {
            Name = "일꾼";
            Mineral = 50;
            Console.WriteLine($"기본 생성자 호출, 이름 : {Name}, 미네랄: {Mineral}");
        }
        public SCV(string name, int mineral)
        {
            Name = name;
            Mineral = mineral;
            Console.WriteLine($"인자있는 생성자 호출, 이름 : {Name}, 미네랄: {Mineral}");
        }
    }

    //this 키워드
    // 자기자신을 가리킨다.
    class Barracks
    {
        public string Name;
        public int Mineral;

        public Barracks()
        {
            Name = "배럭";
            Mineral = 150;
            Console.WriteLine($"기본 생성자 호출, 이름 : {Name}, 미네랄: {Mineral}");
        }
        public Barracks(string Name, int Mineral)
        {
            this.Name = Name;
            this.Mineral = Mineral;
            Console.WriteLine($"인자있는 생성자 호출, 이름 : {this.Name}, 미네랄: {this.Mineral}");
        }
        public void Train_Unit()
        {

        }
    }

    //미네랄 클래스 
    class Mineral
    {
        public int Minerals;
        //public int Pieces;

        public Mineral()
        {
            Minerals = 1500;
            Console.WriteLine("미네랄 생성");
            //Pieces = 7;
        }
        //public Mineral(int Minerals)
        //{
        //    this.Minerals = Minerals;
        //    //this.Pieces = Pieces;
        //}
    }

    class Game
    {
        public static int mineral;
        public static int gas;
        public static int population;
        
        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 : {mineral} , 가스 : {gas} , 인구수 : {population}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game.mineral = 50;
            Game.gas = 0;
            Game.population = 4;
            Game.ShowInfo();
            SCV scv = new SCV();
            Barracks barracks = new Barracks("바락스", 160);
            Marine marine = new Marine("해병", 50);
            //클래스의 배열
            Mineral[] minerals = new Mineral[7];
            for(int i=0; i < minerals.Length; i++)
            {
                minerals[i] = new Mineral();
            }

        }
    }
}
