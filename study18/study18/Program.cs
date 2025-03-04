using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace study18
{
    //클래스 시그니처 기본구성

    //[접근지정자] [수정자] class 클래스이름 : 부모클래스 , 인터페이스
    //public        abstract
    //private       sealed
    //protected     static
    //              partial

    //기본 클래스
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }


    }
    //상속하는 클래스
    public class Warrior : Player
    {
        public int Strength { get; set; }

    }
    //인터페이스를 구현하는 클래스
    //public class Enemy : IAttacable, IMovable
    //{
    //    public void Attack()
    //    {

    //    }
    //    public void Move()
    //    {

    //    }
    //}

    //추상 클래스
    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("프로그램 종료");
            //string path = Environment.GetEnvironmentVariable("PATH");
            // Environment.Exit(0);
            //Console.WriteLine($"paht : {path}");
            //Random random = new Random();
            //int rnd = random.Next(1, 101);
            //Console.WriteLine($"Random Number : {rnd}");

            //프로그램 실행 시간 구하기
            //Stopwatch stopwatch = Stopwatch.StartNew();
            ////실행코드
            //for(int i=0; i<100; i++)
            //{
            //    Thread.Sleep(1);
            //}
            //stopwatch.Stop();
            //Console.WriteLine("시간 : " + stopwatch.ElapsedMilliseconds+"ms");

            //정규식
            //string input = "Hello, My phone number is 010-1234-5678.";

            //string pattern = @"\d{3}-\d{4}-\d{4}"; //전화번호 패턴 정규식은 검색해서 필요한거 찾아서

            //bool isMatch = Regex.IsMatch(input, pattern);

            //Console.WriteLine($"전화번호가 존재하는가? {isMatch}");

            //값 형식과 참조 형식
            //값 형식은 stack에 , 참조 형식은 heap에 저장된다.

            //int valueType = 10;
            //object referenceType = valueType;

            //valueType = 20;

            //Console.WriteLine($"Value Type: {valueType}");
            //Console.WriteLine($"Reference Type: {referenceType}");

            //박싱과 언박싱
            //값 형식을 참조형식으로 변환(박싱), 다시 값 형식으로 변환(언박싱)

            //int value = 42;
            //object boxed = value; // 박싱

            //int unboxed = (int)boxed;

            //Console.WriteLine($"Boxed = {boxed}");
            //Console.WriteLine($"UnBoxed = {unboxed}");

            // is as 연산자
            // null 값이 있는 타입을 안전하게 변환(as)

            //object obj = "Hello";
            //Console.WriteLine(obj is string); //true
            //Console.WriteLine(obj is int); // false

            //object obj = "Hello";
            //string str = obj as string;

            //Console.WriteLine(str is string);

            //object obj = 42; //class
            //var value = 123; //struct
            //if(obj is int number)
            //{
            //    Console.WriteLine($"Nubmer : {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Not a Number");
            //}
            //문자열 다루기
            //string greeting = "Hello";
            //string name = "Alice";

            //string message = greeting + "," + name + "!";
            //Console.WriteLine(message);
            //Console.WriteLine($"Length of name: {name.Length}");
            //Console.WriteLine($"To Upper : {name.ToUpper()}");
            //Console.WriteLine($"SubString : {name.Substring(1)}"); // 부분문자열

            //string text = "C# is awesome";
            //Console.WriteLine($"Contains 'awesome' : {text.Contains("awesome")}");
            //Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");
            //Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");
            //Console.WriteLine($"Replace 'awesome' with 'great' : {text.Replace("awesome", "great")}");

            //StringBuilder sb = new StringBuilder("Hello");
            //sb.Append(",");
            //sb.Append("World");

            //Console.WriteLine(sb.ToString());

            //string 과 StringBuilder 클래스 성능차이 비교
            //반복적으로 문자열을 수정할때 StringBuilder가 효율적
            //int iter = 10000;
            //Stopwatch sw = Stopwatch.StartNew();
            //string text = "";

            //for(int i=0; i<iter; i++)
            //{
            //    text += "a";
            //}

            //sw.Stop();
            //Console.WriteLine($"String : {sw.ElapsedMilliseconds}ms");

            //sw.Restart();
            //StringBuilder sb = new StringBuilder();

            //for (int i = 0; i < iter; i++)
            //{
            //    sb.Append("a");

            //}
            //sw.Stop();
            //Console.WriteLine($"StringBuilder : {sw.ElapsedMilliseconds}ms");

            //예외처리하기

            //예외는 프로그램 실행 중 발생하는 오류, 예외처리를 하면 프로그램이 중단되지 않고 실행을 계속할 수 있다.
            //try catch
            //while (true)
            //{

            //    try
            //    {
            //        int[] numbers = { 1, 2, 3 };
            //        Console.WriteLine(numbers[5]); //오류 발생
            //    }
            //    catch (IndexOutOfRangeException ex)
            //    {
            //        Console.WriteLine($"Error : {ex.Message}");
            //    }
            //}

            //try
            //{
            //    int number = int.Parse("not number");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"Format Error: {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("항상 실행된다.");
            //}

            //try
            //{
            //    int number1 = int.Parse("ABC");
            //}catch(Exception ex)
            //{
            //    Console.WriteLine($"General Error : {ex.Message}");
            //}

            //throw 구문으로 직접 예외 발생시키기
            //try
            //{
            //    int age = -5;
            //    if(age < 0)
            //    {
            //        throw new ArgumentException("Age cannot be negative");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"Exception: {ex.Message}");
            //}


        }
    }
}
