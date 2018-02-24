using System;

namespace LinearFunction
{
    public class LinearFunction
    {
        public parametr_a parametr_a { get; private set; }
        public parametr_b parametr_b { get; private set; }
        public LinearFunction(parametr_a a, parametr_b b)
        {
            this.parametr_a = a;
            this.parametr_b = b;
        }

        public string PrintViewOfFormula()
        {
            if (parametr_a.Value == 0 && parametr_b.Value == 0)
            {
                throw new FunctionParametrs_a_and_b_SetToZeroException();
            }
            var ax = parametr_a.Value + "x";
            var b = parametr_b.Value;

            return String.Format("f(x) = {0} {1}", ax, b);
        }
    }

    public class FunctionParametrs_a_and_b_SetToZeroException : Exception
    {

    }

    public class parametr_a
    {
        private const int _defaultValue = 1;
        private int? _value;
        public int Value
        {
            get
            {
                if (_value == null)
                {
                    return _defaultValue;
                }
                return _value.Value;
            }
        }

        public parametr_a(int value)
        {
            _value = value;
        }

        public parametr_a()
        {
        }
    }

    public class parametr_b
    {
        private const int _defaultValue = 0;
        private int? _value;
        public int Value
        {
            get
            {
                if (_value == null)
                {
                    return _defaultValue;
                }
                return _value.Value;
            }
        }

        public parametr_b(int value)
        {
            _value = value;
        }

        public parametr_b()
        {
        }
    }

}
