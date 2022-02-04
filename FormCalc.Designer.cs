namespace BasicStandardCalculator
{
    partial class FormCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.calculationLabel = new System.Windows.Forms.Label();
            this.calculationTab = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonMemory = new System.Windows.Forms.Button();
            this.buttonMemPlus = new System.Windows.Forms.Button();
            this.buttonMemMinus = new System.Windows.Forms.Button();
            this.buttonClick7 = new System.Windows.Forms.Button();
            this.buttonClick8 = new System.Windows.Forms.Button();
            this.buttonClick9 = new System.Windows.Forms.Button();
            this.buttonClick4 = new System.Windows.Forms.Button();
            this.buttonClick5 = new System.Windows.Forms.Button();
            this.buttonClick6 = new System.Windows.Forms.Button();
            this.buttonClick1 = new System.Windows.Forms.Button();
            this.buttonClick2 = new System.Windows.Forms.Button();
            this.buttonClick3 = new System.Windows.Forms.Button();
            this.buttonClick0 = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonClickPoint = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cECleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.debugStrip = new System.Windows.Forms.StatusStrip();
            this.debugLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.debugTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            this.debugStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculationLabel
            // 
            this.calculationLabel.AutoSize = true;
            this.calculationLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculationLabel.Location = new System.Drawing.Point(13, 35);
            this.calculationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.calculationLabel.Name = "calculationLabel";
            this.calculationLabel.Size = new System.Drawing.Size(117, 20);
            this.calculationLabel.TabIndex = 0;
            this.calculationLabel.Text = "calculationLabel";
            // 
            // calculationTab
            // 
            this.calculationTab.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculationTab.Location = new System.Drawing.Point(12, 61);
            this.calculationTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.calculationTab.Name = "calculationTab";
            this.calculationTab.ReadOnly = true;
            this.calculationTab.Size = new System.Drawing.Size(380, 27);
            this.calculationTab.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(12, 99);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 69);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "CE";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.eventCE);
            // 
            // buttonMemory
            // 
            this.buttonMemory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMemory.Location = new System.Drawing.Point(89, 99);
            this.buttonMemory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMemory.Name = "buttonMemory";
            this.buttonMemory.Size = new System.Drawing.Size(70, 69);
            this.buttonMemory.TabIndex = 3;
            this.buttonMemory.Text = "MRC";
            this.buttonMemory.UseVisualStyleBackColor = true;
            // 
            // buttonMemPlus
            // 
            this.buttonMemPlus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMemPlus.Location = new System.Drawing.Point(166, 99);
            this.buttonMemPlus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMemPlus.Name = "buttonMemPlus";
            this.buttonMemPlus.Size = new System.Drawing.Size(70, 69);
            this.buttonMemPlus.TabIndex = 4;
            this.buttonMemPlus.Text = "M+";
            this.buttonMemPlus.UseVisualStyleBackColor = true;
            // 
            // buttonMemMinus
            // 
            this.buttonMemMinus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMemMinus.Location = new System.Drawing.Point(243, 99);
            this.buttonMemMinus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMemMinus.Name = "buttonMemMinus";
            this.buttonMemMinus.Size = new System.Drawing.Size(70, 69);
            this.buttonMemMinus.TabIndex = 5;
            this.buttonMemMinus.Text = "M-";
            this.buttonMemMinus.UseVisualStyleBackColor = true;
            // 
            // buttonClick7
            // 
            this.buttonClick7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClick7.Location = new System.Drawing.Point(89, 176);
            this.buttonClick7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClick7.Name = "buttonClick7";
            this.buttonClick7.Size = new System.Drawing.Size(70, 69);
            this.buttonClick7.TabIndex = 6;
            this.buttonClick7.Text = "7";
            this.buttonClick7.UseVisualStyleBackColor = true;
            this.buttonClick7.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonClick8
            // 
            this.buttonClick8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClick8.Location = new System.Drawing.Point(166, 176);
            this.buttonClick8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClick8.Name = "buttonClick8";
            this.buttonClick8.Size = new System.Drawing.Size(70, 69);
            this.buttonClick8.TabIndex = 7;
            this.buttonClick8.Text = "8";
            this.buttonClick8.UseVisualStyleBackColor = true;
            this.buttonClick8.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonClick9
            // 
            this.buttonClick9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClick9.Location = new System.Drawing.Point(243, 176);
            this.buttonClick9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClick9.Name = "buttonClick9";
            this.buttonClick9.Size = new System.Drawing.Size(70, 69);
            this.buttonClick9.TabIndex = 8;
            this.buttonClick9.Text = "9";
            this.buttonClick9.UseVisualStyleBackColor = true;
            this.buttonClick9.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonClick4
            // 
            this.buttonClick4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClick4.Location = new System.Drawing.Point(89, 252);
            this.buttonClick4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClick4.Name = "buttonClick4";
            this.buttonClick4.Size = new System.Drawing.Size(70, 69);
            this.buttonClick4.TabIndex = 9;
            this.buttonClick4.Text = "4";
            this.buttonClick4.UseVisualStyleBackColor = true;
            this.buttonClick4.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonClick5
            // 
            this.buttonClick5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClick5.Location = new System.Drawing.Point(166, 252);
            this.buttonClick5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClick5.Name = "buttonClick5";
            this.buttonClick5.Size = new System.Drawing.Size(70, 69);
            this.buttonClick5.TabIndex = 10;
            this.buttonClick5.Text = "5";
            this.buttonClick5.UseVisualStyleBackColor = true;
            this.buttonClick5.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonClick6
            // 
            this.buttonClick6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClick6.Location = new System.Drawing.Point(243, 252);
            this.buttonClick6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClick6.Name = "buttonClick6";
            this.buttonClick6.Size = new System.Drawing.Size(70, 69);
            this.buttonClick6.TabIndex = 11;
            this.buttonClick6.Text = "6";
            this.buttonClick6.UseVisualStyleBackColor = true;
            this.buttonClick6.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonClick1
            // 
            this.buttonClick1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClick1.Location = new System.Drawing.Point(89, 328);
            this.buttonClick1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClick1.Name = "buttonClick1";
            this.buttonClick1.Size = new System.Drawing.Size(70, 69);
            this.buttonClick1.TabIndex = 12;
            this.buttonClick1.Text = "1";
            this.buttonClick1.UseVisualStyleBackColor = true;
            this.buttonClick1.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonClick2
            // 
            this.buttonClick2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClick2.Location = new System.Drawing.Point(166, 328);
            this.buttonClick2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClick2.Name = "buttonClick2";
            this.buttonClick2.Size = new System.Drawing.Size(70, 69);
            this.buttonClick2.TabIndex = 13;
            this.buttonClick2.Text = "2";
            this.buttonClick2.UseVisualStyleBackColor = true;
            this.buttonClick2.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonClick3
            // 
            this.buttonClick3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClick3.Location = new System.Drawing.Point(243, 328);
            this.buttonClick3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClick3.Name = "buttonClick3";
            this.buttonClick3.Size = new System.Drawing.Size(70, 69);
            this.buttonClick3.TabIndex = 14;
            this.buttonClick3.Text = "3";
            this.buttonClick3.UseVisualStyleBackColor = true;
            this.buttonClick3.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonClick0
            // 
            this.buttonClick0.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClick0.Location = new System.Drawing.Point(89, 404);
            this.buttonClick0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClick0.Name = "buttonClick0";
            this.buttonClick0.Size = new System.Drawing.Size(70, 69);
            this.buttonClick0.TabIndex = 15;
            this.buttonClick0.Text = "0";
            this.buttonClick0.UseVisualStyleBackColor = true;
            this.buttonClick0.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDivide.Location = new System.Drawing.Point(322, 99);
            this.buttonDivide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(70, 69);
            this.buttonDivide.TabIndex = 16;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.handleOperation);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMultiply.Location = new System.Drawing.Point(322, 176);
            this.buttonMultiply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(70, 69);
            this.buttonMultiply.TabIndex = 17;
            this.buttonMultiply.Text = "x";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.handleOperation);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinus.Location = new System.Drawing.Point(322, 252);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(70, 69);
            this.buttonMinus.TabIndex = 18;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.handleOperation);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlus.Location = new System.Drawing.Point(322, 328);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(70, 145);
            this.buttonPlus.TabIndex = 19;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.handleOperation);
            // 
            // buttonClickPoint
            // 
            this.buttonClickPoint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClickPoint.Location = new System.Drawing.Point(166, 404);
            this.buttonClickPoint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClickPoint.Name = "buttonClickPoint";
            this.buttonClickPoint.Size = new System.Drawing.Size(70, 69);
            this.buttonClickPoint.TabIndex = 20;
            this.buttonClickPoint.Text = ",";
            this.buttonClickPoint.UseVisualStyleBackColor = true;
            this.buttonClickPoint.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEquals.Location = new System.Drawing.Point(243, 404);
            this.buttonEquals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(70, 69);
            this.buttonEquals.TabIndex = 21;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.handleEquals);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(408, 24);
            this.mainMenuStrip.TabIndex = 22;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cECleanToolStripMenuItem,
            this.debugModeToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // cECleanToolStripMenuItem
            // 
            this.cECleanToolStripMenuItem.Name = "cECleanToolStripMenuItem";
            this.cECleanToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cECleanToolStripMenuItem.Text = "CE/Clean";
            this.cECleanToolStripMenuItem.Click += new System.EventHandler(this.eventCE);
            // 
            // debugModeToolStripMenuItem
            // 
            this.debugModeToolStripMenuItem.Name = "debugModeToolStripMenuItem";
            this.debugModeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.debugModeToolStripMenuItem.Text = "Debug Mode";
            this.debugModeToolStripMenuItem.Click += new System.EventHandler(this.toggleDebugMode);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.eventAbout);
            // 
            // debugStrip
            // 
            this.debugStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugLabel});
            this.debugStrip.Location = new System.Drawing.Point(0, 464);
            this.debugStrip.Name = "debugStrip";
            this.debugStrip.Size = new System.Drawing.Size(408, 22);
            this.debugStrip.TabIndex = 23;
            this.debugStrip.Text = "statusStrip1";
            // 
            // debugLabel
            // 
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(108, 17);
            this.debugLabel.Text = "Wait for response...";
            // 
            // debugTimer
            // 
            this.debugTimer.Tick += new System.EventHandler(this.debugTicking);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSqrt.Location = new System.Drawing.Point(13, 176);
            this.buttonSqrt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(70, 69);
            this.buttonSqrt.TabIndex = 24;
            this.buttonSqrt.Text = "SQRT";
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.handleOperation);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(13, 404);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 69);
            this.button1.TabIndex = 25;
            this.button1.Text = "+/-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.handlePlusMinus);
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 486);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.debugStrip);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonClickPoint);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonClick0);
            this.Controls.Add(this.buttonClick3);
            this.Controls.Add(this.buttonClick2);
            this.Controls.Add(this.buttonClick1);
            this.Controls.Add(this.buttonClick6);
            this.Controls.Add(this.buttonClick5);
            this.Controls.Add(this.buttonClick4);
            this.Controls.Add(this.buttonClick9);
            this.Controls.Add(this.buttonClick8);
            this.Controls.Add(this.buttonClick7);
            this.Controls.Add(this.buttonMemMinus);
            this.Controls.Add(this.buttonMemPlus);
            this.Controls.Add(this.buttonMemory);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.calculationTab);
            this.Controls.Add(this.calculationLabel);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormCalc";
            this.Text = "Calculator Example";
            this.Load += new System.EventHandler(this.initComponent);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.debugStrip.ResumeLayout(false);
            this.debugStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label calculationLabel;
        private System.Windows.Forms.TextBox calculationTab;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonMemory;
        private System.Windows.Forms.Button buttonMemPlus;
        private System.Windows.Forms.Button buttonMemMinus;
        private System.Windows.Forms.Button buttonClick7;
        private System.Windows.Forms.Button buttonClick8;
        private System.Windows.Forms.Button buttonClick9;
        private System.Windows.Forms.Button buttonClick4;
        private System.Windows.Forms.Button buttonClick5;
        private System.Windows.Forms.Button buttonClick6;
        private System.Windows.Forms.Button buttonClick1;
        private System.Windows.Forms.Button buttonClick2;
        private System.Windows.Forms.Button buttonClick3;
        private System.Windows.Forms.Button buttonClick0;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonClickPoint;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cECleanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem debugModeToolStripMenuItem;
        private StatusStrip debugStrip;
        private ToolStripStatusLabel debugLabel;
        private System.Windows.Forms.Timer debugTimer;
        private Button buttonSqrt;
        private Button button1;
    }
}

