using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowtozeniezOOCzCSharp
{
    interface IFlying
    {
        public void Fly();
    }

    class Bird : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Lift me up..");
        }
    }

    class Boeing : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Let me go..");
        }
    }

    /*
    class Program
    {
        static void Main(string[] args)
        {
            Boeing OBoeing = new Boeing();
            Bird OBird = new Bird();
            OBoeing.Fly();
            OBird.Fly();
        }
    }
    */
}
