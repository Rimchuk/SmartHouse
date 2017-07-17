using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    public class Brightness : IBrightness
    {
        private int curentBrightness;
        private int maxBrightness;

        public Brightness(int maxBrightness)
        {
            curentBrightness = maxBrightness / 2;
            this.maxBrightness = maxBrightness;
        }

        public int CurentBrightness
        {
            get
            {
                return curentBrightness;
            }
        }

        public void UpBrightness()					
        {					
            if (curentBrightness < maxBrightness)					
            {					
                curentBrightness++;					
            }
        }




        public void Darker()
        {
            if (curentBrightness > 1)
            {
            curentBrightness--;
            }
        } 	
}
}

    				
					
