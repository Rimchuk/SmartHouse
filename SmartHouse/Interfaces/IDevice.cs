using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IDevice
    {
        bool State { set; get; }
        void On();
        void Off();
    }
}
