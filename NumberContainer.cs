namespace BasicStandardCalculator {
    /*
     * Used for containing numeric variable with a state.
     */
    internal class NumberContainer {
        private double _value = 0.0D;

        /* 0 - Empty; 1 - Filled */
        private byte _state = 0;

        /*
         * Applies specific value and changes state.
         */
        public void SetValue(double d) {
            this._value = d;
            this._state = 1;
        }

        /*
         * Clears value and state.
         */
        public void Clean() {
            this._value = 0.0D;
            this._state = 0;
        }

        /*
         * Returns value of the container.
         */
        public double Value() {
            return _value;
        }

        /*
         * Returns state (as boolean, state being equal to 1).
         */
        public bool State()  {
            return _state == 1;
        }
    }
}
