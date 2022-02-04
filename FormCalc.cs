using System;
using System.Drawing;
using System.Windows.Forms;

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

        private void eventAboutMe(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }
    }
}
