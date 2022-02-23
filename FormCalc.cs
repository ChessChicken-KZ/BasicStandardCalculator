namespace BasicStandardCalculator {
    public partial class FormCalc : Form {
        private readonly NumberContainer firstValue = new();
        private readonly NumberContainer secondValue = new();
        private readonly NumberContainer mrcValue = new();

        /*
         * 0 - Not
         * 1 - Plus
         * 2 - Minus
         * 3 - Multiply
         * 4 - Divide
         * 5 - Sqrt
         * 255 - Finished state
         */
        private byte current = 0;

        private void updateLabel() {
            this.calculationLabel.Text =
                (firstValue.State() ? firstValue.Value().ToString() : "") +
                CalculationUtils.processCurrent(current) + 
                (secondValue.State() ? secondValue.Value().ToString() : "");
        }

        public FormCalc() {
            InitializeComponent();
        }

        /*
         * First event, loads and sets up additional calculator appearance.
         */
        private void initComponent(object sender, EventArgs e) {
            this.debugStrip.Visible = false;
            this.debugTimer.Interval = 1000;
            this.debugTimer.Stop();

            this.labelMemory.Visible = false;
            this.labelMemory.Text = "M";

            this.calculationLabel.BackColor = Color.White;
            this.calculationLabel.Text = "";
            this.calculationTab.Text = "";
        }

        /*
         * Event, clears calculator.
         */
        private void handleClear(object sender, EventArgs? e) {
            this.calculationTab.Text = "";
            this.firstValue.Clean();
            this.secondValue.Clean();
            this.current = 0;
            this.updateLabel();
        }
        
        /*
         * Event, inputs the value into tab and processes it.
         */
        private void handleObject(object sender, EventArgs args) {
            if(this.current == 255) handleClear(sender, args);
            this.calculationTab.AppendText(((Button)sender).Text);
        }

        /*
         * Event, inputs the value into tab and processes it.
         */
        private void handleObject(object sender, byte args)
        {
            if (this.current == 255) handleClear(sender, null);
            this.calculationTab.AppendText(args.ToString());
        }

        /*
         * Event, some things related to calculator's memory part (MCR, M+, M-).
         */
        private void handleMemory(object sender, EventArgs args) {
            if (this.calculationTab.Text.Length < 1)
                return;

            string s = ((Button)sender).Text.Remove(0, 1);

            if (s.Equals("RC"))
                this.calculationTab.Text = mrcValue.Value().ToString();
            else {
                double d = (s == "-" ? -1 : 1) * double.Parse(this.calculationTab.Text);
                if (mrcValue.Value().Equals(d)) {
                    mrcValue.Clean();
                    this.labelMemory.Visible = false;
                } else {
                    mrcValue.SetValue(d);
                    this.labelMemory.Visible = true;
                }
            }

        }

        /*
         * Event, inputs the specific operation and processes it.
         */
        private void handleOperation(object sender, EventArgs e) {
            handleOperation(((Button)sender).Text.ToCharArray()[0], e);
        }

        /*
         * Event, inputs the specific operation and processes it.
         */
        private void handleOperation(char c, EventArgs e)
        {
            if (this.calculationTab.Text.Length < 1)
                return;

            if (this.current == 0 || this.current == 255)
            {
                if (this.current == 255)
                    this.secondValue.Clean();

                this.firstValue.SetValue(double.Parse(this.calculationTab.Text));
                this.current = CalculationUtils.processString(c.ToString());
                this.calculationTab.Text = "";

                if (this.current == 5)
                {
                    this.calculationTab.Text = CalculationUtils.processVars(this.firstValue.Value(), this.secondValue.Value(), this.current).ToString();
                    this.current = 255;
                }

                this.updateLabel();
            }
            else
            {
                this.handleEquals(null, e);
                this.handleOperation(c, e);
            }
        }

        /*
         * Event, calculate and output the result.
         */
        private void handleEquals(object? sender, EventArgs e) {
            if (current == 0 || this.calculationTab.Text.Length < 1)
                return;

            this.secondValue.SetValue(double.Parse(this.calculationTab.Text));
            this.updateLabel();
            this.calculationTab.Text = CalculationUtils.processVars(this.firstValue.Value(), this.secondValue.Value(), this.current).ToString();
            this.current = 255;
        }

        /*
         * Event, change the tab number's value '+/-'.
         */
        private void handlePlusMinus(object sender, EventArgs e) {
            try {
                this.calculationTab.Text = double.Parse(this.calculationTab.Text) > 0 ? this.calculationTab.Text.Insert(0, "-") : this.calculationTab.Text.Remove(0, 1);
            } catch (FormatException) { /* Skip it. */}
        }

        /*
         * For debug checking, timer's toggle event.
         */
        private void toggleDebugMode(object sender, EventArgs e) {
            this.debugStrip.Visible = !this.debugStrip.Visible;
            if (this.debugStrip.Visible)
                this.debugTimer.Start();
            else
                this.debugTimer.Stop();
        }

        /*
         * For debug checking, timer's tick event.
         */
        private void handleDebugTicking(object sender, EventArgs e) {
            this.debugLabel.Text =
                "C: " + this.current.ToString() + //State value
                " ; F: " + this.firstValue.Value().ToString() + //First value
                " ; S: " + this.secondValue.Value().ToString() + //Second value
                " ; CTT: " + this.calculationTab.Text + //Calculator tab panel
                " ; MRC: " + this.mrcValue.Value().ToString(); //Memory holder value
        }

        /*
         * For debug checking, timer's tick event.
         */
        private void toggleAboutInfo(object sender, EventArgs e) {
            this.current = 255;
            this.calculationTab.Text = "Basic Standart Calculator! https://github.com/ChessChicken-KZ/BasicStandardCalculator";
        }

        /*
         * Events, handles keyboard input and processes it.
         */
        private void handleKeyboardPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                byte f = byte.Parse(e.KeyChar.ToString());
                if (f >= 0 && f <= 9)
                    handleObject(sender, f);
            }
            catch (FormatException)
            {
                if (CalculationUtils.operationChars.Contains(e.KeyChar))
                    handleOperation(e.KeyChar, e);
                if (e.KeyChar == '+' || e.KeyChar == '-')
                    handlePlusMinus(sender, e);
                if (e.KeyChar == '=' || e.KeyChar == (char)Keys.Enter)
                    handleEquals(sender, e);
                if(e.KeyChar == (char)Keys.Escape)
                    handleClear(sender, e);
            }
        }
    }
}
