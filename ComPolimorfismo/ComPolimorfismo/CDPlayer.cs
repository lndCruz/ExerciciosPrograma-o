using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPolimorfismo
{
    class CDPlayer : MusicPlayer
    {
        public override void Play()
        {
            Console.WriteLine("Tocando CD Player");
        }
    }
}
