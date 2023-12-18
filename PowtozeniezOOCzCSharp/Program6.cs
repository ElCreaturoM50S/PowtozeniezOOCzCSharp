using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowtozeniezOOCzCSharp
{
    class KlasaGeneryczna<A,B>
    {
        public A generyczna { get; set; }
        public B tenString { get; set; }

        public override string ToString()
        {
            return $"1:{generyczna}, 2:{tenString}";
        }
    }
    class Program6
    { 
        static void Main(string[] args)
        {
            KlasaGeneryczna<int, string> testGeneryczy = new KlasaGeneryczna<int, string>();

            testGeneryczy.generyczna = 1;
            testGeneryczy.tenString = "Testowy String";

            Console.WriteLine(testGeneryczy);

            testGeneryczy.generyczna = 1251251;
            testGeneryczy.tenString = "NieTestowy";

            Console.WriteLine(testGeneryczy);
        }
    }
}
