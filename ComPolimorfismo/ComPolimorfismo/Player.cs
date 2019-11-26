using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPolimorfismo
{
    class Player
    {
        MusicPlayer player;

        public Player(MusicPlayer player)
        {
            this.player = player;
        }

        public void setPlayer(MusicPlayer player)
        {
            this.player = player;
        }

        public void Play()
        {
            player.Play();
        }
    }
}
