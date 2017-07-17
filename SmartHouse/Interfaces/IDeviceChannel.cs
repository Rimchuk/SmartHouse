using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IDeviceChannel : IDevice
    {
        IChannel Channel { set; get; }
        void NextChannel();
        void PreviouseChannel();
        void LastChannel();
        void SetChannel(int channel);
    }
}
