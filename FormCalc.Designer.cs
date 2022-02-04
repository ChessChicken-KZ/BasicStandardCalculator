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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cECleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculationLabel
            // 
            this.calculationLabel.AutoSize = true;
            this.calculationLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculationLabel.Location = new System.Drawing.Point(13, 51);
            this.calculationLabel.Name = "calculationLabel";
            this.calculationLabel.Size = new System.Drawing.Size(117, 20);
            this.calculationLabel.TabIndex = 0;
            this.calculationLabel.Text = "calculationLabel";
            // 
            // calculationTab
            // 
            this.calculationTab.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculationTab.Location = new System.Drawing.Point(12, 74);
            this.calculationTab.Name = "calculationTab";
            this.calculationTab.ReadOnly = true;
            this.calculationTab.Size = new System.Drawing.Size(326, 27);
            this.calculationTab.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(12, 107);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 60);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "CE";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.eventCE);
            // 
            // buttonMemory
            // 
            this.buttonMemory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMemory.Location = new System.Drawing.Point(78, 107);
            this.buttonMemory.Name = "buttonMemory";
            this.buttonMemory.Size = new System.Drawing.Size(60, 60);
            this.buttonMemory.TabIndex = 3;
            this.buttonMemory.Text = "MRC";
            this.buttonMemory.UseVisualStyleBackColor = true;
            // 
            // buttonMemPlus
            // 
            this.buttonMemPlus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMemPlus.Location = new System.Drawing.Point(144, 107);
            this.buttonMemPlus.Name = "buttonMemPlus";
            this.buttonMemPlus.Size = new System.Drawing.Size(60, 60);
            this.buttonMemPlus.TabIndex = 4;
            this.buttonMemPlus.Text = "M+";
            this.buttonMemPlus.UseVisualStyleBackColor = true;
            // 
            // buttonMemMinus
            // 
            this.buttonMemMinus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMemMinus.Location = new System.Drawing.Point(210, 107);
            this.buttonMemMinus.Name = "buttonMemMinus";
            this.buttonMemMinus.Size = new System.Drawing.Size(60, 60);
            this.buttonMemMinus.TabIndex = 5;
            this.buttonMemMinus.Text = "M-";
            this.buttonMemMinus.UseVisualStyleBackColor = true;
            // 
            // buttonClick7
            // 
            this.buttonClick7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClick7.Location = new System.Drawing.Point(78, 173);
            this.buttonClick7.Name = "buttonClick7";
            this.buttonClick7.Size = new System.Drawing.Size(60, 60);
            this.buttonClick7.TabIndex = 6;
            this.buttonClick7.Text = "7";
            this.buttonClick7.UseVisualStyleBackColor = true;
            this.buttonClick7.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonClick8
            // 
            this.buttonClick8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClick8.Location = new System.Drawing.Point(144, 173);
            this.buttonClick8.Name = "buttonClick8";
            this.buttonClick8.Size = new System.Drawing.Size(60, 60);
            this.buttonClick8.TabIndex = 7;
            this.buttonClick8.Text = "8";
            this.buttonClick8.UseVisualStyleBackColor = true;
            this.buttonClick8.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonClick9
            // 
            this.buttonClick9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClick9.Location = new System.Drawing.Point(210, 173);
            this.buttonClick9.Name = "buttonClick9";
            this.buttonClick9.Size = new System.Drawing.Size(60, 60);
            this.buttonClick9.TabIndex = 8;
            this.buttonClick9.Text = "9";
            this.buttonClick9.UseVisualStyleBackColor = true;
            this.buttonClick9.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonClick4
            // 
            this.buttonClick4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClick4.Location = new System.Drawing.Point(78, 239);
            this.buttonClick4.Name = "buttonClick4";
            this.buttonClick4.Size = new System.Drawing.Size(60, 60);
            this.buttonClick4.TabIndex = 9;
            this.buttonClick4.Text = "4";
            this.buttonClick4.UseVisualStyleBackColor = true;
            this.buttonClick4.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonClick5
            // 
            this.buttonClick5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClick5.Location = new System.Drawing.Point(144, 239);
            this.buttonClick5.Name = "buttonClick5";
            this.buttonClick5.Size = new System.Drawing.Size(60, 60);
            this.buttonClick5.TabIndex = 10;
            this.buttonClick5.Text = "5";
            this.buttonClick5.UseVisualStyleBackColor = true;
            this.buttonClick5.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonClick6
            // 
            this.buttonClick6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClick6.Location = new System.Drawing.Point(210, 239);
            this.buttonClick6.Name = "buttonClick6";
            this.buttonClick6.Size = new System.Drawing.Size(60, 60);
            this.buttonClick6.TabIndex = 11;
            this.buttonClick6.Text = "6";
            this.buttonClick6.UseVisualStyleBackColor = true;
            this.buttonClick6.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonClick1
            // 
            this.buttonClick1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClick1.Location = new System.Drawing.Point(78, 305);
            this.buttonClick1.Name = "buttonClick1";
            this.buttonClick1.Size = new System.Drawing.Size(60, 60);
            this.buttonClick1.TabIndex = 12;
            this.buttonClick1.Text = "1";
            this.buttonClick1.UseVisualStyleBackColor = true;
            this.buttonClick1.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonClick2
            // 
            this.buttonClick2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClick2.Location = new System.Drawing.Point(144, 305);
            this.buttonClick2.Name = "buttonClick2";
            this.buttonClick2.Size = new System.Drawing.Size(60, 60);
            this.buttonClick2.TabIndex = 13;
            this.buttonClick2.Text = "2";
            this.buttonClick2.UseVisualStyleBackColor = true;
            this.buttonClick2.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonClick3
            // 
            this.buttonClick3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClick3.Location = new System.Drawing.Point(210, 305);
            this.buttonClick3.Name = "buttonClick3";
            this.buttonClick3.Size = new System.Drawing.Size(60, 60);
            this.buttonClick3.TabIndex = 14;
            this.buttonClick3.Text = "3";
            this.buttonClick3.UseVisualStyleBackColor = true;
            this.buttonClick3.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonClick0
            // 
            this.buttonClick0.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClick0.Location = new System.Drawing.Point(78, 371);
            this.buttonClick0.Name = "buttonClick0";
            this.buttonClick0.Size = new System.Drawing.Size(60, 60);
            this.buttonClick0.TabIndex = 15;
            this.buttonClick0.Text = "0";
            this.buttonClick0.UseVisualStyleBackColor = true;
            this.buttonClick0.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivide.Location = new System.Drawing.Point(278, 107);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(60, 60);
            this.buttonDivide.TabIndex = 16;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.handleOperation);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiply.Location = new System.Drawing.Point(278, 173);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(60, 60);
            this.buttonMultiply.TabIndex = 17;
            this.buttonMultiply.Text = "x";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.handleOperation);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(278, 239);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(60, 60);
            this.buttonMinus.TabIndex = 18;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.handleOperation);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(278, 305);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(60, 126);
            this.buttonPlus.TabIndex = 19;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.handleOperation);
            // 
            // buttonClickPoint
            // 
            this.buttonClickPoint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClickPoint.Location = new System.Drawing.Point(144, 371);
            this.buttonClickPoint.Name = "buttonClickPoint";
            this.buttonClickPoint.Size = new System.Drawing.Size(60, 60);
            this.buttonClickPoint.TabIndex = 20;
            this.buttonClickPoint.Text = ",";
            this.buttonClickPoint.UseVisualStyleBackColor = true;
            this.buttonClickPoint.Click += new System.EventHandler(this.handleObject);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEquals.Location = new System.Drawing.Point(210, 371);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(60, 60);
            this.buttonEquals.TabIndex = 21;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.handleEquals);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(350, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
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
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.eventAboutMe);
            // 
            // cECleanToolStripMenuItem
            // 
            this.cECleanToolStripMenuItem.Name = "cECleanToolStripMenuItem";
            this.cECleanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cECleanToolStripMenuItem.Text = "CE/Clean";
            this.cECleanToolStripMenuItem.Click += new System.EventHandler(this.eventCE);
            // 
            // debugModeToolStripMenuItem
            // 
            this.debugModeToolStripMenuItem.Name = "debugModeToolStripMenuItem";
            this.debugModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.debugModeToolStripMenuItem.Text = "Debug Mode";
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 443);
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
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCalc";
            this.Text = "Calculator Example";
            this.Load += new System.EventHandler(this.initComponent);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cECleanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem debugModeToolStripMenuItem;
    }
}

