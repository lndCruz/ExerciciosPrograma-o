using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemPolimorfismo
{
    class Player
    {
        MusicPlayer mp3 = new MP3Player();
        MusicPlayer cd = new CDPlayer();

        public void PlayMP3()
        {
            mp3.Play("MP3");
        }

        public void PlayCD()
        {
            cd.Play("CD");
        }

    }
}
