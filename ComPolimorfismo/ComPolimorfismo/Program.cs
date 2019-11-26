using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPolimorfismo
{
    class Program
    {

        static void Main(string[] args)
        {
            MusicPlayer musicPlayer = new MP3Player();
            var player = new Player(musicPlayer);
            int num;

            do
            {

                Console.WriteLine("Digite 1-MP3 | 2-CD \n");
                num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        player.Play();
                        break;

                    case 2:
                        player.setPlayer(new CDPlayer());
                        player.Play();
                        break;
                }

            } while (num != 0);        

            Console.Read();
        }
    }
}
