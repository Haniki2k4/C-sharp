using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    #region ke thua

        #region ke thua
        /*class Animal
        {
            protected double Weight;
            protected double Height;
            protected double Legs;

            public Animal()
            {

            }

            public Animal(double w, double h, double l)
            {
                w = Weight;
                h = Height;
                l = Legs;
            }

            public void Info()
            {
                Console.WriteLine("Weight: " + Weight + "\nHeight: " + Height + "\nLegs:");
            }
        }

        class Cat : Animal
        {
            public Cat()
            {
                Weight = 500;
                Height = 20;
                Legs = 4;
            }

            //Goi constructor cua lop cha thong qua tu khoa base
            public Cat (double w, double h, double l) : base(w,h,l)
            {

            }

            public new void Info() //tu khoa new chi dinh day la 1 ham info moi cua Cat
            {
                Console.WriteLine("Info of Cat:");
                base.Info();
            }
        }*/
        #endregion

        #region ke thua ghi de phuong thuc
        /*class Animal
        {
            //virtual de khai bao 1 pg thuc ao (phg thuc co the ghi de dc)
            public virtual void Speak()
            {
                Console.WriteLine("Animal is speaking....");
            }
        }
        class Cat : Animal
        {
            public void Speak()
            {
                Console.WriteLine("Cat is speaking....");
            }
        }
        class Dog : Animal
        {
            //override đánh dấu phương thức ghi đè lên phương thức của lớp cha.
            public override void Speak()
            {
                Console.WriteLine("Dog is speaking....");
            }
        }*/
        #endregion

        #region lop truu tuong & pg thuc thuan ao
        //phg thuc Speak() phai ghi de
        //pg thuc speak() ko co dinh nghia gi ben trong
            /*abstract class Animal //lop truu tuong
            {
                public abstract void Speak(); // phg thuc thuan ao
            }
            class Cat : Animal
            {
                public override void Speak() //bat buoc phai co override
                {
                    Console.WriteLine("Cat is speaking....");
                    Console.WriteLine("Moew Moew....");
                }
            }
            class Dog : Animal
            {
                public override void Speak()
                {
                    Console.WriteLine("Dog is speaking");
                    Console.WriteLine("Gof Gof...");
                }
            }*/
    //khi ke thua 1 lop abstract thi bat buoc phai override tat ca cac phg thuc thuan ao
    #endregion
    /*về phạm vi:
     - private:ko đc phép kế thừa
     - protected, public: đc phép kế thừa*/

    #endregion

    #region interface
    interface ISpeak
    {
        void Speak();
    }

    class Animal : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("Animal speaking....");
        }
    }
    #endregion
    
    
    internal class Program
    { 
        static void Main(string[] args)
        {
            #region


            #region ke thua
            /*Cat BlackCat = new Cat();
            BlackCat.Info();*/
            #endregion

            #region ke thua ghi de 
            /*Animal dog = new Dog();
            Animal cat = new Cat();
            dog.Speak(); //sdung speak cua class dog vi speak dog da ghi de len lop Animal
            cat.Speak();// sdung speak dc ke thua tu class Aniamal*/
            #endregion

            #region lop truu tuong & pg thuc thuan ao
           /* Animal cat = new Cat();
            Animal dog = new Dog();

            cat.Speak();
            dog.Speak();*/
            #endregion

            #endregion

            #region interface
            //1 tap cac thanh phan chi co khai bap ma khong co dinh nghia
            //ghi de 1 thanh phan trong interface khong can override
            //interface co the ke thua nhieu interface khac nhg ko the ke thua lop
            Animal animal = new Animal();
            animal.Speak();
            
            #endregion

            Console.ReadLine();
        }
    }
}
