namespace BasicStandardCalculator
{
    internal class CalculationUtils
    {
        public static double processVars(double a, double b, byte current)
        {
            switch (current)
            {
                case 0: return a;
                case 1: return a + b;
                case 2: return a - b;
                case 3: return a * b;
                case 4: return a / b;
                case 5: return Math.Sqrt(a);
                default: return 0;
            }
        }

        public static string processCurrent(byte b)
        {
            switch (b)
            {
                case 1: return "+";
                case 2: return "-";
                case 3: return "*";
                case 4: return "/";
                case 5: return "SQRT";
                default: return "";
            }
        }

        public static byte processString(string s)
        {
            switch (s)
            {
                case "+": return 1;
                case "-": return 2;
                case "x": return 3;
                case "/": return 4;
                case "SQRT": return 5;
                default: return 0;
            }
        }
    }
}
