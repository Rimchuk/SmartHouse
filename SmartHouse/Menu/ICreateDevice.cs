using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface ICreateDevice
    {
        TV CreateTV();
        Radio CreateRadio();
        Lamp CreateLamp();
     }
}
