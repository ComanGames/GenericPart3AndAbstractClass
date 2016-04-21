using System;

namespace GenericPart3AndAbstractClass
{
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
}