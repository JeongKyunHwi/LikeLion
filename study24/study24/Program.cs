using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study24
{

    //interface IAnimal
    //{
    //    void MakeSound();

    //}

    //class Dog : IAnimal
    //{
    //    public void MakeSound()
    //    {
    //        Console.WriteLine("멍멍");
    //    }
    //}
    
    //class Cat : IAnimal
    //{
    //    public void MakeSound()
    //    {
    //        Console.WriteLine("야옹");
    //    }
    //}
    //interface IAnimal
    //{
    //    void Speak();
    //}
    //public class Dog : IAnimal
    //{
    //    public void Speak()
    //    {
    //        Console.WriteLine("멍멍");
    //    }
    //}

    //class Trainer
    //{
    //    public void Train(IAnimal animal)
    //    {
    //        Console.WriteLine("동물이 소리를 냅니다.");
    //        animal.Speak();
    //    }
    //}

    interface iPayment
    {
        void ProcessPayment();

    }

    //신용카드 결제 클래스
    class CreditCardPayment : iPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("신용카드 결제 완료");
        }
    }

    class PayPalPayment : iPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("PayPal 결제 완료");
        }
    }


    //결제 처리기
    class PaymentProcessor
    {
        public void Pay(iPayment payment)
        {
            payment.ProcessPayment();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //IAnimal mydog = new Dog();
            //mydog.MakeSound();

            //IAnimal mycat = new Cat();
            //mycat.MakeSound();

            //Trainer trainer = new Trainer();
            //IAnimal mydog = new Dog();

            //trainer.Train(mydog);

            PaymentProcessor processor = new PaymentProcessor();

            iPayment creditcard = new CreditCardPayment();
            iPayment paypal = new PayPalPayment();

            processor.Pay(creditcard);
            processor.Pay(paypal);

        }
    }
}
