using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study20
{

    class Program
    {
        //class Cup<T>
        //{
        //    public T Content { get; set; }
        //}

        //커스텀 컬렉션
        //class SimpleCollection: IEnumerable<int>
        //{
        //    private int[] data = { 1, 2, 3, 4, 5 };

        //    public IEnumerator<int> GetEnumerator()
        //    {
        //        foreach(var item in data)
        //        {
        //            yield return item;
        //        }
        //    }
        //    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        //}


        static void Main(string[] args)
        {
            //var collection = new SimpleCollection();

            //foreach(var i in collection)
            //{
            //    Console.WriteLine(i);
            //}


            //제네릭 사용하기
            //<T> 제네릭 클래스를 사용하면 특정타입에 종속되지 않는 범용 클래스를 만들 수 있다.

            //Cup<string> cupOfString = new Cup<String> { Content = "Coffee" };
            //Cup<int> cupOfInt = new Cup<int> { Content = 42 };

            //Console.WriteLine($"CupOfString: {cupOfString.Content}");
            //Console.WriteLine($"CupOfInt: {cupOfInt.Content}");

            //Stack<int> stack = new Stack<int>();

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            //List<string> list = new List<string> { "Alice ","Bob", "Charlie"};
            //list.Add("Dave");

            //foreach(var name in list)
            //{
            //    Console.WriteLine(name);
            //}

            //IEnumerator
            //C# 컬렉션 순회 반복할 수 있는 인터페이스

            //ArrayList arrayList = new ArrayList { "Alice", "Bob", "Charlie" };

            //IEnumerator enumerator = arrayList.GetEnumerator();

            //while (enumerator.MoveNext()) // 다음 요소가 있는지 확인
            //{
            //    Console.WriteLine(enumerator.Current); //현재 요소 출력
            //}

            //Dictionary<string, int> ages = new Dictionary<string, int>();

            //ages["금도끼"] = 10;
            //ages["은도끼"] = 5;
            //ages["돌도끼"] = 1;

            //foreach(var i in ages){
            //    Console.WriteLine($"{i.Key} : {i.Value}");
            //}

            //null값 
            //참조형식 null값을 가질 수 있고, 값 형식은 null값을 가질 수 없음

            //string str = null;
            //if(str == null)
            //{
            //    Console.WriteLine("str is null");
            //}

            //값형식에 null
            //int? nullableInt = null;
            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString(): "No Value");
            //nullableInt = 10;
            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No Value");

            //null 값을 다루는 연산 소개하기 ?? , ?. 연산자
            // ?? 연산자를 사용해 null 인 경우 대체값을 제공하고, ?. 은 null안전 접근을 한다.

            //string str = null;
            //Console.WriteLine(str ?? "DefaultValue"); // str 이 null이면  "DefaultValue" 

            ////str = "Hello";
            //Console.WriteLine(str?.Length); //str이 null이 아니므로 길이 출력

            //LINQ 는 확장 메서드 형태로 제공된다.
            //Lenguage Integrated Query 를 사용해 컬렉션을 쿼리할 수 있다.
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //var evenNumber = numbers.Where(n => n % 2 == 0);

            //foreach(var num in evenNumber)
            //{
            //    Console.WriteLine(num);
            //}




        }
    }
}
