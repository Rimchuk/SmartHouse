using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    public class Lamp : Device, IDeviceBrightness
    {
        public IBrightness Brightness { set; get; }

        public Lamp(IBrightness brightness)
        {

            Brightness = brightness;
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
            return base.ToString() + " brightness:" + Brightness.CurentBrightness;
        }
    }
}

