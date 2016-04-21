using System;

namespace GenericPart3AndAbstractClass
{
    internal class Dolphin : MainSavec
    {
        public Dolphin(string puzirk, float d):base(puzirk,d) {
            Console.WriteLine("I call Dolhin constructor");
        }
    }
}