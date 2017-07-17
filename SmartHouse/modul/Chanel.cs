using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    public class Channel : IChannel
    {
        private int channel;
        private int countChannel;
        private int tempChannel;

        public Channel(int countChannel)
        {
            this.channel = 1;
            this.countChannel = countChannel;
        }

        public int CountChannel
        {
            get
            {
                return countChannel;
            }
        }

        public int MyChannel
        {
            get
            {
                return channel;
            }
        }

        public void NextChannel()
        {
            if (channel < countChannel)
            {
                tempChannel = channel;
                channel++;
            }
        }

        public void PreviouseChannel()
        {
            if (channel > 1)
            {
                tempChannel = channel;
                channel--;
            }
        }

        public void LastChannel()
        {


            int temp = channel;
            channel = tempChannel;
            tempChannel = temp;
        }

        public void SetChanel(int channel)
        {
            if (channel < countChannel && channel > 0)
            {
                tempChannel = this.channel;
                this.channel = channel;
            }
        }
    }
}
