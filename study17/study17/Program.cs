using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study17
{

    //class Person
    //{
    //    private string name; //내부변수

    //    public void SetName(string name)
    //    {
    //        this.name = name;
    //    }
    //    public string GetName()
    //    {
    //        return this.name;
    //    }
    //}

    //C#의 프로퍼티 property
    //class Person
    //{
    //    private string name;

    //    public string Name
    //    {
    //        get { return name; } //Getter
    //        set { name = value; } // Setter
    //    }
    //}

    //프로퍼티가 자동으로 구현되는 방식
    class Person
    {
        private int count = 100;
        
        public string Name { get; set; }

        public int Count
        {
            get { return count; }
        }

        public float Balance { get; private set; }

        public void AddBal()
        {
            Balance += 100;
        }
    }

    class Marine
    {
        public string Name { get; private set; } = "마린";
        public int mineral { get; set; } = 100;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            //p.SetName("private name");
            //Console.WriteLine(p.GetName());
            p.Name = "홍길동";
            //p.Count = 34;
            p.AddBal();
            p.AddBal();
            Console.WriteLine("이름 : " + p.Name + " " + p.Count+ " "+ p.Balance);

            
            Marine m = new Marine();
            //m.Name = "해병";
            m.mineral = 50;
            Console.WriteLine("이름 : " + m.Name + " " + m.mineral + " " );

        }
    }
}
