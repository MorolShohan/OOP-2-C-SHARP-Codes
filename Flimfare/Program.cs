using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flimfare
{
     class Program
    {
        static void Main(string[] args)
        {
            Movielist avengers = new Movielist("The Avengers", 300, "dog");
            Console.WriteLine(avengers.Hero);

            Movielist avengersendgame = new Movielist("The Avengers ultron", 30089, "IRONMAN");
            Console.WriteLine(avengersendgame.Hero);
        }
    }
}
