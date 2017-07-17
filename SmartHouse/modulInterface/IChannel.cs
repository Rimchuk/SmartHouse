using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    public interface IChannel
    {
        int MyChannel { get; }
        int CountChannel { get; }
        void SetChanel(int channel);
        void NextChannel();
        void PreviouseChannel();
        void LastChannel();
    }
}
