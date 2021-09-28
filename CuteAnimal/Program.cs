using System;

namespace CuteAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Print();
            cat.Meow();
            cat.Sleep();
            cat.Print();
        }
    }
}
