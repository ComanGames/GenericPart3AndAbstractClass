using System;

namespace GenericPart3AndAbstractClass
{
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