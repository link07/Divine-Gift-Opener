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
            this.btnOnOff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.cbLeft = new System.Windows.Forms.CheckBox();
            this.cbRight = new System.Windows.Forms.CheckBox();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOnOff
            // 
            this.btnOnOff.Location = new System.Drawing.Point(266, 58);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(75, 23);
            this.btnOnOff.TabIndex = 0;
            this.btnOnOff.Text = "Start";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X-Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y-Location";
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
            this.nudX.Location = new System.Drawing.Point(124, 9);
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
            this.nudX.Size = new System.Drawing.Size(120, 20);
            this.nudX.TabIndex = 8;
            this.nudX.Value = new decimal(new int[] {
            28,
            0,
            0,
            0});
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(124, 33);
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
            this.nudY.Size = new System.Drawing.Size(120, 20);
            this.nudY.TabIndex = 9;
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
            this.cbLeft.Location = new System.Drawing.Point(271, 7);
            this.cbLeft.Name = "cbLeft";
            this.cbLeft.Size = new System.Drawing.Size(70, 17);
            this.cbLeft.TabIndex = 10;
            this.cbLeft.Text = "Left Click";
            this.cbLeft.UseVisualStyleBackColor = true;
            // 
            // cbRight
            // 
            this.cbRight.AutoSize = true;
            this.cbRight.Location = new System.Drawing.Point(271, 30);
            this.cbRight.Name = "cbRight";
            this.cbRight.Size = new System.Drawing.Size(77, 17);
            this.cbRight.TabIndex = 11;
            this.cbRight.Text = "Right Click";
            this.cbRight.UseVisualStyleBackColor = true;
            // 
            // nudTime
            // 
            this.nudTime.Increment = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.nudTime.Location = new System.Drawing.Point(124, 56);
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(120, 20);
            this.nudTime.TabIndex = 12;
            this.nudTime.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mins between repeat";
            // 
            // intervalClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 103);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudTime);
            this.Controls.Add(this.cbRight);
            this.Controls.Add(this.cbLeft);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOnOff);
            this.Name = "intervalClick";
            this.Text = "Interval Click";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.intervalClick_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.CheckBox cbLeft;
        private System.Windows.Forms.CheckBox cbRight;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.Label label3;


    }
}

