using System;

namespace System
{
    abstract class Animals
    {
        public abstract void Eat();
        public abstract void Sleep();
    }

    class Dog : Animals
    {
        public bool isAgressive;

        public override void Eat()
        {
            Console.Write("\nJa dadzą to zjem");
        }
        public override void Sleep()
        {
            Console.Write("\neepy...");
        }
    }
    /*
    class Program
    {
        static void Main(string[] args)
        {
            Dog Norbi = new Dog();
            Norbi.Eat();
            Norbi.Sleep();
        }
    }
    */
}