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

        public void Add(int addingValue)
        {
            if(addingValue + Value > 9000){
                throw new ITS_OVER_9000_Exception();
            }
            Value += addingValue;
        }
    }

    public class ITS_OVER_9000_Exception : Exception
    {

    }
}
