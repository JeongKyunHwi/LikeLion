using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study15_Class
{

    class Program
    {
        struct Student
        {
            public string name;
            public int kor;
            public int eng;
            public int math;

            public void Print()
            {
                Console.WriteLine($"{name} \t {kor} \t {eng} \t {math} ");
            }
        }
        static void Main(string[] args)
        {
            Student[] student = new Student[3];
            student[0].name = "홍길동";
            student[0].kor = 100;
            student[0].eng = 80;
            student[0].math = 70;

            student[1].name = "홍길란";
            student[1].kor = 90;
            student[1].eng = 10;
            student[1].math = 20;

            student[2].name = "홍길순";
            student[2].kor = 20;
            student[2].eng = 55;
            student[2].math = 70;

            Console.WriteLine("이름 \t 국어 \t 영어 \t 수학");

            foreach(Student student1 in student)
            {
                student1.Print();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{student[i].name} \t {student[i].kor} \t {student[i].eng} \t {student[i].math}");
            }
            //Console.WriteLine($"{student[0].name} \t {student[0].kor} \t {student[0].eng} \t {student[0].math}");
            //Console.WriteLine($"{student[1].name} \t {student[1].kor} \t {student[1].eng} \t {student[1].math}");
            //Console.WriteLine($"{student[2].name} \t {student[2].kor} \t {student[2].eng} \t {student[2].math}");

        }
    }
}
