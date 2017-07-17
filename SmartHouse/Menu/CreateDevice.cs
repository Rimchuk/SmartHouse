using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class CreateDevice : ICreateDevice
    {
        public TV CreateTV()
        {
            return new TV(new Channel(100), new Sound(50), new Brightness(50));
        }
        public Radio CreateRadio()
        {
            return new Radio(new Channel(200), new Sound(50));
        }
        public Lamp CreateLamp()
        {
            return new Lamp(new Brightness(10));
        }

    }
}
