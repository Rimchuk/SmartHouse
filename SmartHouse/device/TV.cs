using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
 public   class TV : Device, IDeviceSound, IDeviceChannel, IDeviceBrightness

    {
        public IChannel Channel { set; get; }
        public ISound Sound { set; get; }
        public IBrightness Brightness { set; get; }
        

        public TV(IChannel channel, ISound sound, IBrightness brightness)
        {
            Channel = channel;
            Sound = sound;
            Brightness = brightness;
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
        public void UpBrightness()
        {
            Brightness.UpBrightness();
        }
        public void Darker()
        {
            Brightness.Darker();
        }

        public override string ToString()
        {
            return base.ToString() + ", channel: " + Channel.MyChannel + "/" + Channel.CountChannel + ", sound level: " + Sound.SoundLevel + ", brightness:" + Brightness.CurentBrightness;
        }
    }

}
