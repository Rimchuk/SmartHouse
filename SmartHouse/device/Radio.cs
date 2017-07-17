using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    public class Radio : Device, IDeviceSound, IDeviceChannel
    {
        public IChannel Channel { set; get; }
        public ISound Sound { set; get; }


        public Radio(IChannel channel, ISound sound)
        {
            Channel = channel;
            Sound = sound;
        }

        public void NextChannel()
        {
            Channel.NextChannel();
        }

        public void PreviouseChannel()
        {
            Channel.PreviouseChannel();
        }

        public void SetChannel(int channel)
        {
            Channel.SetChanel(channel);
        }

        public void LastChannel()
        {
            Channel.LastChannel();
        }

        public void Louder()
        {
            Sound.Louder();
        }

        public void Quiet()
        {
            Sound.Quiet();
        }

        public void Mute()
        {
            Sound.Mute();
        }

        public void Unmute()
        {
            Sound.Unmute();
        }


        public override string ToString()
        {
            return base.ToString() + ", channel: " + Channel.MyChannel + "/" + Channel.CountChannel + ", sound level: " + Sound.SoundLevel;
        }
    }
}
