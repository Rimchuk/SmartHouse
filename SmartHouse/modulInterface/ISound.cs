using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    public interface ISound
    {
        int SoundLevel { get; }
        void Louder();
        void Quiet();
        void Mute();
        void Unmute();
    }
}
