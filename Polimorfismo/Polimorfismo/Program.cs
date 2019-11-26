using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            var Player = new Player();

            Player.PlayCD();

            Player.PlayMP3();

            Console.Read();
        }
    }
}
