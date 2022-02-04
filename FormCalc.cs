namespace BasicStandardCalculator
{
    public partial class FormCalc : Form
    {
        private NumberContainer firstValue = new NumberContainer();
        private NumberContainer secondValue = new NumberContainer();
        private NumberContainer mrcValue = new NumberContainer();

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

        

        private void updateLabel()
        {
            this.calculationLabel.Text =
                (firstValue.State() ? firstValue.Value().ToString() : "") +
                CalculationUtils.processCurrent(current) + 
                (secondValue.State() ? secondValue.Value().ToString() : "");
        }

        public FormCalc()
        {
            InitializeComponent();
        }

        private void initComponent(object sender, EventArgs e)
        {
            this.debugStrip.Visible = false;
            this.debugTimer.Interval = 1000;
            this.debugTimer.Stop();

            this.calculationLabel.BackColor = Color.White;
            this.calculationLabel.Text = "";
            this.calculationTab.Text = "0";
        }

        private void eventCE(object sender, EventArgs e)
        {
            this.calculationTab.Clear();
            this.firstValue.Clean();
            this.secondValue.Clean();
            this.current = 0;
            this.updateLabel();
        }
        
        private void handleObject(object sender, EventArgs args)
        {
            if(this.current == 255) eventCE(sender, args);
            this.calculationTab.AppendText(((Button)sender).Text);
        }

        private void handleOperation(object sender, EventArgs e)
        {
            if(this.current == 0 || this.current == 255)
            {
                if (this.current == 255)
                    this.secondValue.Clean();
                this.firstValue.SetValue(double.Parse(this.calculationTab.Text));
                this.current = CalculationUtils.processString(((Button)sender).Text);
                this.calculationTab.Text = "";
                this.updateLabel();
            }
        }

        private void handleEquals(object sender, EventArgs e)
        {
            if (current == 0)
                return;
            this.secondValue.SetValue(double.Parse(this.calculationTab.Text));
            this.updateLabel();
            this.calculationTab.Text = CalculationUtils.processVars(this.firstValue.Value(), this.secondValue.Value(), this.current).ToString();
            this.current = 255;
        }

        private void toggleDebugMode(object sender, EventArgs e)
        {
            this.debugStrip.Visible = !this.debugStrip.Visible;
            if (this.debugStrip.Visible)
                this.debugTimer.Start();
            else
                this.debugTimer.Stop();
        }

        private void debugTicking(object sender, EventArgs e)
        {
            this.debugLabel.Text =
                "C: " + this.current.ToString() +
                " ; F: " + this.firstValue.Value().ToString() +
                " ; S: " + this.secondValue.Value().ToString() +
                " ; MRC: " + this.mrcValue.Value().ToString();
        }

        private void eventAbout(object sender, EventArgs e)
        {
            this.current = 255;
            this.calculationTab.Text = "Basic Standart Calculator! https://github.com/ChessChicken-KZ/BasicStandardCalculator";
        }
    }
}
