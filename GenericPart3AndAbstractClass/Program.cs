using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace GenericPart3AndAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {

            MainSavec dog = new Dog("REX", 10,50);
            MainSavec human = new Human("Yura", 2);
            MainSavec dolphin = new Dolphin("Puzirk",0.1f);
            dog.Info();
            human.Info();
            dolphin.Info();
            Dog RealDog = (Dog) dog;
            RealDog.Run();
            Console.ReadKey();


        }
    }

    internal class Dolphin : MainSavec
    {
        public Dolphin(string puzirk, float d):base(puzirk,d) {
            Console.WriteLine("I call Dolhin constructor");
        }
    }

    internal class Human : MainSavec
    {
        public Human(string yura, int i):base(yura,i) { }
    }

    internal class Dog : MainSavec
    {
        protected float _speed ;

        public Dog(string rex, float i, float speed) : base(rex, i)
        {
            _speed = speed;
        }

        protected override string PersonalInfo()
        {
            return $"This is dog and his speed is {_speed}";
        }
        public void Run()
        {

            Console.WriteLine(base.PersonalInfo()+" Dog is Running");
        }
    }

    public abstract class MainSavec
    {
        protected string _name;
        protected float _hair;

        protected MainSavec(string name, float hair)
        {
            Console.WriteLine("I call base constructor");
            _name = name;
            _hair = hair;
        }

        protected virtual string PersonalInfo()
        {
            return "Savec";
        }
        public void Info()
        {
            Console.WriteLine(PersonalInfo()+$" The name is {_name}. Length of hair is{_hair} "); 
        }
    }
}
