using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    public class Sound : ISound
    {
        private int soundLevel;
        private int maxSound;
        private bool muteStatus = false;
        private int temp;

        public Sound(int maxSound)
        {
            soundLevel = maxSound / 2;
            this.maxSound = maxSound;
        }

        public int SoundLevel
        {
            get
            {
                return soundLevel;
            }
        }

        public void Louder()
        {
            if (soundLevel < maxSound)
            {
                soundLevel++;
                muteStatus = false;
            }

        }

        public void Quiet()
        {
            if (soundLevel > 1)
            {
                soundLevel--;
                muteStatus = false;
            }
        }

        public void Mute()
        {
            if (soundLevel != 0 && !muteStatus)
            {
                temp = soundLevel;
                soundLevel = 0;
                muteStatus = true;
            }
        }

        public void Unmute()
        {
            if (muteStatus)
            {
                soundLevel = temp;
                muteStatus = false;
            }
        }
    }
}
