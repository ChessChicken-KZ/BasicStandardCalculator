namespace BasicStandardCalculator
{
    internal class NumberContainer
    {
        private double _value = 0.0D;

        /*
         * 0 - Empty
         * 1 - Filled
         */
        private byte _state = 0;

        public void SetValue(double d)
        {
            this._value = d;
            this._state = 1;
        }

        public void Clean()
        {
            this._value = 0.0D;
            this._state = 0;
        }

        public double Value()
        {
            return _value;
        }

        public bool State()
        {
            return _state == 1;
        }
    }
}
