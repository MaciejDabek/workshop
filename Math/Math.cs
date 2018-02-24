using System;

namespace Math
{
    public class Math
    {
        public int Value {get; private set;}

        public Math()
        {

        }

        public Math(int initialValue)
        {
            Value = initialValue;
        }

        public Math Add(int addingValue)
        {
            if(addingValue + Value > 9000){
                throw new ITS_OVER_9000_Exception();
            }
            Value += addingValue;
            return this;
        }

        public Math Sub(int substracingValue)
        {
            Value -= substracingValue;
            return this;
        }
    }

    public class ITS_OVER_9000_Exception : Exception
    {

    }
}
