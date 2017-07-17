using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IDeviceBrightness : IDevice
    {
        IBrightness Brightness { set; get; }
        void UpBrightness();
        void Darker();
    }
}
