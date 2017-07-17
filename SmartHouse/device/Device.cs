namespace SmartHouse
{
    public abstract class Device  : IDevice
    {
        private bool state;

        public Device()
        {
        }

        public Device(bool state)
        {
            this.state = state;
        }

        public bool State 
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public virtual void On()
        {
            state = true;
        }

        public virtual void Off()
        {
            state = false;
        }

        public override string ToString()
        {
            string strState;

            if (this.state)
            {
                strState = "ON";
            }
            else
            {
                strState = "OFF";
            }

            return ", state: " + strState;
        }
    }
}