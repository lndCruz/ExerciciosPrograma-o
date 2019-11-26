using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPolimorfismo
{
    class MP3Player : MusicPlayer
    {
        public override void Play()
        {
            Console.WriteLine("Tocando MP3 Play");
        }
    }
}
