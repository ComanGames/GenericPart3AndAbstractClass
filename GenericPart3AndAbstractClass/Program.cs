using System;

namespace GenericPart3AndAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstPartOfLesson();
            double D = ConvertNumber<int, double>(5);
            Console.WriteLine(D);
            int I = ConvertNumber<double, int>(D);
            Console.WriteLine(I);
            float F = ConvertNumber<int, float>(I);
            Console.WriteLine(F);
            double d = ConvertNumber<string, double>("5.0");
            Console.WriteLine(d+1);
            Console.ReadKey();
        }

        private static K ConvertNumber<T, K>(T number) where T:IConvertible
        {
            return (K) Convert.ChangeType(number, typeof (K));
        }

        private static void FirstPartOfLesson()
        {
            MainSavec dog = new Dog("REX", 10, 50);
            MainSavec human = new Man("Yura", 2);
            MainSavec dolphin = new Dolphin("Puzirk", 0.1f);
            dog.Info();
            human.Info();
            dolphin.Info();
            Dog RealDog = (Dog) dog;
            RealDog.Run();
        }
    }
}
