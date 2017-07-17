using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IDeviceSound : IDevice
    {
        ISound Sound { set; get; }
        void Louder();
        void Quiet();
        void Mute();
        void Unmute();
    }
}
