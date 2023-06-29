using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Music
    {
        private SoundPlayer player = new SoundPlayer();

        public void playMusic()
        {
            this.player.SoundLocation = @"../../files/woosh_low_long01-98755.wav";
            this.player.PlayLooping();
        }
    }
}
