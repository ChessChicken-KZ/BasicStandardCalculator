namespace BasicStandardCalculator {
    /// <summary>
    /// Some helpful switch methods for simpler coding.
    /// </summary>
    internal class CalculationUtils {
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

        public static byte processString(string s) {
            return s switch {
                "+" => 1,
                "-" => 2,
                "x" => 3,
                "/" => 4,
                "SQRT" => 5,
                _ => 0,
            };
        }
    }
}
