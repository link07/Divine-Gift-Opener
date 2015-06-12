namespace Interval_Click_Graphic
{
    partial class intervalClick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(intervalClick));
            this.btnOnOff = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.cbLeft = new System.Windows.Forms.CheckBox();
            this.cbRight = new System.Windows.Forms.CheckBox();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTimeSinceClick = new System.Windows.Forms.Label();
            this.btnFindXY = new System.Windows.Forms.Button();
            this.lblCurrX = new System.Windows.Forms.Label();
            this.lblCurrY = new System.Windows.Forms.Label();
            this.cbDouble = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOnOff
            // 
            this.btnOnOff.Location = new System.Drawing.Point(228, 69);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(75, 23);
            this.btnOnOff.TabIndex = 8;
            this.btnOnOff.Text = "Start";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(12, 5);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(58, 13);
            this.lblX.TabIndex = 5;
            this.lblX.Text = "X-Location";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(12, 30);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(58, 13);
            this.lblY.TabIndex = 6;
            this.lblY.Text = "Y-Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(76, 3);
            this.nudX.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudX.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(130, 20);
            this.nudX.TabIndex = 1;
            this.nudX.Value = new decimal(new int[] {
            28,
            0,
            0,
            0});
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(76, 28);
            this.nudY.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudY.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(130, 20);
            this.nudY.TabIndex = 2;
            this.nudY.Value = new decimal(new int[] {
            984,
            0,
            0,
            0});
            // 
            // cbLeft
            // 
            this.cbLeft.AutoSize = true;
            this.cbLeft.Checked = true;
            this.cbLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLeft.Location = new System.Drawing.Point(226, 4);
            this.cbLeft.Name = "cbLeft";
            this.cbLeft.Size = new System.Drawing.Size(70, 17);
            this.cbLeft.TabIndex = 4;
            this.cbLeft.Text = "Left Click";
            this.cbLeft.UseVisualStyleBackColor = true;
            // 
            // cbRight
            // 
            this.cbRight.AutoSize = true;
            this.cbRight.Location = new System.Drawing.Point(226, 26);
            this.cbRight.Name = "cbRight";
            this.cbRight.Size = new System.Drawing.Size(77, 17);
            this.cbRight.TabIndex = 5;
            this.cbRight.Text = "Right Click";
            this.cbRight.UseVisualStyleBackColor = true;
            // 
            // nudTime
            // 
            this.nudTime.DecimalPlaces = 4;
            this.nudTime.Increment = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.nudTime.Location = new System.Drawing.Point(124, 50);
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(82, 20);
            this.nudTime.TabIndex = 3;
            this.nudTime.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mins between repeat";
            // 
            // lblTimeSinceClick
            // 
            this.lblTimeSinceClick.AutoSize = true;
            this.lblTimeSinceClick.Location = new System.Drawing.Point(12, 74);
            this.lblTimeSinceClick.Name = "lblTimeSinceClick";
            this.lblTimeSinceClick.Size = new System.Drawing.Size(115, 13);
            this.lblTimeSinceClick.TabIndex = 14;
            this.lblTimeSinceClick.Text = "Time Since Last Click: ";
            // 
            // btnFindXY
            // 
            this.btnFindXY.Location = new System.Drawing.Point(197, 98);
            this.btnFindXY.Name = "btnFindXY";
            this.btnFindXY.Size = new System.Drawing.Size(106, 23);
            this.btnFindXY.TabIndex = 9;
            this.btnFindXY.Text = "Start XY Display";
            this.btnFindXY.UseVisualStyleBackColor = true;
            this.btnFindXY.Click += new System.EventHandler(this.btnFindXY_Click);
            // 
            // lblCurrX
            // 
            this.lblCurrX.AutoSize = true;
            this.lblCurrX.Location = new System.Drawing.Point(12, 103);
            this.lblCurrX.Name = "lblCurrX";
            this.lblCurrX.Size = new System.Drawing.Size(54, 13);
            this.lblCurrX.TabIndex = 16;
            this.lblCurrX.Text = "Current X:";
            // 
            // lblCurrY
            // 
            this.lblCurrY.AutoSize = true;
            this.lblCurrY.Location = new System.Drawing.Point(95, 103);
            this.lblCurrY.Name = "lblCurrY";
            this.lblCurrY.Size = new System.Drawing.Size(57, 13);
            this.lblCurrY.TabIndex = 17;
            this.lblCurrY.Text = "Current Y: ";
            // 
            // cbDouble
            // 
            this.cbDouble.AutoSize = true;
            this.cbDouble.Checked = true;
            this.cbDouble.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDouble.Location = new System.Drawing.Point(226, 48);
            this.cbDouble.Name = "cbDouble";
            this.cbDouble.Size = new System.Drawing.Size(86, 17);
            this.cbDouble.TabIndex = 6;
            this.cbDouble.Text = "Double Click";
            this.cbDouble.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // intervalClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 126);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbDouble);
            this.Controls.Add(this.lblCurrY);
            this.Controls.Add(this.lblCurrX);
            this.Controls.Add(this.btnFindXY);
            this.Controls.Add(this.lblTimeSinceClick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudTime);
            this.Controls.Add(this.cbRight);
            this.Controls.Add(this.cbLeft);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnOnOff);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "intervalClick";
            this.Text = "Interval Click by Tyler / Zafar v1.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.intervalClick_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.CheckBox cbLeft;
        private System.Windows.Forms.CheckBox cbRight;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTimeSinceClick;
        private System.Windows.Forms.Button btnFindXY;
        private System.Windows.Forms.Label lblCurrX;
        private System.Windows.Forms.Label lblCurrY;
        private System.Windows.Forms.CheckBox cbDouble;
        private System.Windows.Forms.Button button1;


    }
}

