namespace BasicStandardCalculator {
    /*
     * Kind of necessary part of the code to handle operations and convertations between numbers.
     */
    internal class CalculationUtils {
        /*
         * Basically four chars, array used for keyboard support.
         */
        public static readonly char[] operationChars = new char[]
        {
            '+', '-', '*', '/'
        };

        /*
         * Applies and returns operation to the specific values by code.
         */
        public static double processVars(double a, double b, byte current) {
            return current switch {
                0 => a,
                1 => a + b,
                2 => a - b,
                3 => a * b,
                4 => a / b,
                5 => Math.Sqrt(a),
                _ => 0,
            };
        }

        /*
         * Converts code to char value (as string).
         */
        public static string processCurrent(byte b) {
            return b switch {
                1 => "+",
                2 => "-",
                3 => "*",
                4 => "/",
                5 => "SQRT",
                _ => "",
            };
        }

        /*
         * Converts char value (as string) to code.
         */
        public static byte processString(string s) {
            return s switch {
                "+" => 1,
                "-" => 2,
                "*" => 3,
                "/" => 4,
                "SQRT" => 5,
                _ => 0,
            };
        }
    }
}
