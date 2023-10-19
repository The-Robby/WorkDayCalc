namespace WorkDayCalc
{
    partial class Form1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtStartHour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndHour = new System.Windows.Forms.TextBox();
            this.checkHalfDay = new System.Windows.Forms.CheckBox();
            this.checkPaidLunch = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDayHours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLunchTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCalculate.Location = new System.Drawing.Point(12, 38);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(146, 63);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStartHour
            // 
            this.txtStartHour.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WorkDayCalc.Properties.Settings.Default, "StartHour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtStartHour.Location = new System.Drawing.Point(272, 38);
            this.txtStartHour.Name = "txtStartHour";
            this.txtStartHour.Size = new System.Drawing.Size(100, 20);
            this.txtStartHour.TabIndex = 1;
            this.txtStartHour.Text = global::WorkDayCalc.Properties.Settings.Default.StartHour;
            this.txtStartHour.TextChanged += new System.EventHandler(this.txtStartHour_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Hour:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Hour:";
            // 
            // txtEndHour
            // 
            this.txtEndHour.Location = new System.Drawing.Point(272, 80);
            this.txtEndHour.Name = "txtEndHour";
            this.txtEndHour.Size = new System.Drawing.Size(100, 20);
            this.txtEndHour.TabIndex = 4;
            this.txtEndHour.TextChanged += new System.EventHandler(this.txtEndHour_TextChanged);
            // 
            // checkHalfDay
            // 
            this.checkHalfDay.AutoSize = true;
            this.checkHalfDay.Location = new System.Drawing.Point(424, 38);
            this.checkHalfDay.Name = "checkHalfDay";
            this.checkHalfDay.Size = new System.Drawing.Size(67, 17);
            this.checkHalfDay.TabIndex = 6;
            this.checkHalfDay.Text = "Half Day";
            this.checkHalfDay.UseVisualStyleBackColor = true;
            // 
            // checkPaidLunch
            // 
            this.checkPaidLunch.AutoSize = true;
            this.checkPaidLunch.Location = new System.Drawing.Point(424, 63);
            this.checkPaidLunch.Name = "checkPaidLunch";
            this.checkPaidLunch.Size = new System.Drawing.Size(80, 17);
            this.checkPaidLunch.TabIndex = 7;
            this.checkPaidLunch.Text = "Paid Lunch";
            this.checkPaidLunch.UseVisualStyleBackColor = true;
            this.checkPaidLunch.CheckedChanged += new System.EventHandler(this.checkPaidLunch_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "How many hours \r\ndo you have to work:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "(Everything is expressed in hours and minutes. For example: 08:15)";
            // 
            // txtDayHours
            // 
            this.txtDayHours.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WorkDayCalc.Properties.Settings.Default, "DayHours", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDayHours.Location = new System.Drawing.Point(638, 41);
            this.txtDayHours.Name = "txtDayHours";
            this.txtDayHours.Size = new System.Drawing.Size(65, 20);
            this.txtDayHours.TabIndex = 10;
            this.txtDayHours.Text = global::WorkDayCalc.Properties.Settings.Default.DayHours;
            this.txtDayHours.TextChanged += new System.EventHandler(this.txtDayHours_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "How long is your \r\nlunch:";
            // 
            // txtLunchTime
            // 
            this.txtLunchTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WorkDayCalc.Properties.Settings.Default, "LunchTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLunchTime.Location = new System.Drawing.Point(638, 72);
            this.txtLunchTime.Name = "txtLunchTime";
            this.txtLunchTime.Size = new System.Drawing.Size(65, 20);
            this.txtLunchTime.TabIndex = 12;
            this.txtLunchTime.Text = global::WorkDayCalc.Properties.Settings.Default.LunchTime;
            this.txtLunchTime.TextChanged += new System.EventHandler(this.txtLunchTime_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(715, 130);
            this.Controls.Add(this.txtLunchTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDayHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkPaidLunch);
            this.Controls.Add(this.checkHalfDay);
            this.Controls.Add(this.txtEndHour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStartHour);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "End Hour Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtStartHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndHour;
        private System.Windows.Forms.CheckBox checkHalfDay;
        private System.Windows.Forms.CheckBox checkPaidLunch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDayHours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLunchTime;
    }
}

