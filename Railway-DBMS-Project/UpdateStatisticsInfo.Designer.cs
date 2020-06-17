namespace RailWay
{
    partial class UpdateStatisticsInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.most_trip1 = new System.Windows.Forms.Label();
            this.most_departure = new System.Windows.Forms.TextBox();
            this.most_month1 = new System.Windows.Forms.Label();
            this.most_month = new System.Windows.Forms.TextBox();
            this.most_sex1 = new System.Windows.Forms.Label();
            this.most_sex = new System.Windows.Forms.TextBox();
            this.most_end_station1 = new System.Windows.Forms.Label();
            this.most_end_station = new System.Windows.Forms.TextBox();
            this.most_start_station1 = new System.Windows.Forms.Label();
            this.most_start_station = new System.Windows.Forms.TextBox();
            this.showinfo = new System.Windows.Forms.Button();
            this.startstat = new System.Windows.Forms.ComboBox();
            this.endstat = new System.Windows.Forms.ComboBox();
            this.triptime = new System.Windows.Forms.ComboBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(21, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Popular Trip Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(21, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Popular Sex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Location = new System.Drawing.Point(21, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Popular Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(21, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Popular Start Station";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Location = new System.Drawing.Point(21, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Popular End Station";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(428, 72);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(92, 55);
            this.update.TabIndex = 15;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 31);
            this.button2.TabIndex = 22;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(230, 133);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 27;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // most_trip1
            // 
            this.most_trip1.AutoSize = true;
            this.most_trip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.most_trip1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.most_trip1.Location = new System.Drawing.Point(505, 304);
            this.most_trip1.Name = "most_trip1";
            this.most_trip1.Size = new System.Drawing.Size(77, 13);
            this.most_trip1.TabIndex = 37;
            this.most_trip1.Text = "Most Trip Time";
            this.most_trip1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // most_departure
            // 
            this.most_departure.Enabled = false;
            this.most_departure.Location = new System.Drawing.Point(484, 320);
            this.most_departure.Name = "most_departure";
            this.most_departure.Size = new System.Drawing.Size(120, 20);
            this.most_departure.TabIndex = 36;
            // 
            // most_month1
            // 
            this.most_month1.AutoSize = true;
            this.most_month1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.most_month1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.most_month1.Location = new System.Drawing.Point(399, 304);
            this.most_month1.Name = "most_month1";
            this.most_month1.Size = new System.Drawing.Size(63, 13);
            this.most_month1.TabIndex = 35;
            this.most_month1.Text = "Most Month";
            this.most_month1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // most_month
            // 
            this.most_month.Enabled = false;
            this.most_month.Location = new System.Drawing.Point(402, 320);
            this.most_month.Name = "most_month";
            this.most_month.Size = new System.Drawing.Size(60, 20);
            this.most_month.TabIndex = 34;
            // 
            // most_sex1
            // 
            this.most_sex1.AutoSize = true;
            this.most_sex1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.most_sex1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.most_sex1.Location = new System.Drawing.Point(309, 304);
            this.most_sex1.Name = "most_sex1";
            this.most_sex1.Size = new System.Drawing.Size(68, 13);
            this.most_sex1.TabIndex = 33;
            this.most_sex1.Text = "Most Gender";
            this.most_sex1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // most_sex
            // 
            this.most_sex.Enabled = false;
            this.most_sex.Location = new System.Drawing.Point(312, 320);
            this.most_sex.Name = "most_sex";
            this.most_sex.Size = new System.Drawing.Size(64, 20);
            this.most_sex.TabIndex = 32;
            // 
            // most_end_station1
            // 
            this.most_end_station1.AutoSize = true;
            this.most_end_station1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.most_end_station1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.most_end_station1.Location = new System.Drawing.Point(183, 304);
            this.most_end_station1.Name = "most_end_station1";
            this.most_end_station1.Size = new System.Drawing.Size(88, 13);
            this.most_end_station1.TabIndex = 31;
            this.most_end_station1.Text = "Most End Station";
            this.most_end_station1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // most_end_station
            // 
            this.most_end_station.Enabled = false;
            this.most_end_station.Location = new System.Drawing.Point(164, 320);
            this.most_end_station.Name = "most_end_station";
            this.most_end_station.Size = new System.Drawing.Size(120, 20);
            this.most_end_station.TabIndex = 30;
            // 
            // most_start_station1
            // 
            this.most_start_station1.AutoSize = true;
            this.most_start_station1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.most_start_station1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.most_start_station1.Location = new System.Drawing.Point(27, 304);
            this.most_start_station1.Name = "most_start_station1";
            this.most_start_station1.Size = new System.Drawing.Size(91, 13);
            this.most_start_station1.TabIndex = 29;
            this.most_start_station1.Text = "Most Start Station";
            this.most_start_station1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // most_start_station
            // 
            this.most_start_station.Enabled = false;
            this.most_start_station.Location = new System.Drawing.Point(12, 320);
            this.most_start_station.Name = "most_start_station";
            this.most_start_station.Size = new System.Drawing.Size(120, 20);
            this.most_start_station.TabIndex = 28;
            // 
            // showinfo
            // 
            this.showinfo.Location = new System.Drawing.Point(278, 241);
            this.showinfo.Name = "showinfo";
            this.showinfo.Size = new System.Drawing.Size(79, 35);
            this.showinfo.TabIndex = 38;
            this.showinfo.Text = "Show Info";
            this.showinfo.UseVisualStyleBackColor = true;
            this.showinfo.Click += new System.EventHandler(this.showinfo_Click);
            // 
            // startstat
            // 
            this.startstat.FormattingEnabled = true;
            this.startstat.Location = new System.Drawing.Point(230, 12);
            this.startstat.Name = "startstat";
            this.startstat.Size = new System.Drawing.Size(121, 21);
            this.startstat.TabIndex = 39;
            // 
            // endstat
            // 
            this.endstat.FormattingEnabled = true;
            this.endstat.Location = new System.Drawing.Point(230, 49);
            this.endstat.Name = "endstat";
            this.endstat.Size = new System.Drawing.Size(121, 21);
            this.endstat.TabIndex = 40;
            // 
            // triptime
            // 
            this.triptime.FormattingEnabled = true;
            this.triptime.Location = new System.Drawing.Point(230, 170);
            this.triptime.Name = "triptime";
            this.triptime.Size = new System.Drawing.Size(121, 21);
            this.triptime.TabIndex = 41;
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(230, 90);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(121, 21);
            this.Gender.TabIndex = 42;
            // 
            // UpdateStatisticsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 402);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.triptime);
            this.Controls.Add(this.endstat);
            this.Controls.Add(this.startstat);
            this.Controls.Add(this.showinfo);
            this.Controls.Add(this.most_trip1);
            this.Controls.Add(this.most_departure);
            this.Controls.Add(this.most_month1);
            this.Controls.Add(this.most_month);
            this.Controls.Add(this.most_sex1);
            this.Controls.Add(this.most_sex);
            this.Controls.Add(this.most_end_station1);
            this.Controls.Add(this.most_end_station);
            this.Controls.Add(this.most_start_station1);
            this.Controls.Add(this.most_start_station);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UpdateStatisticsInfo";
            this.Text = "UpdateStatisticsInfo";
            this.Load += new System.EventHandler(this.UpdateStatisticsInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label most_trip1;
        private System.Windows.Forms.TextBox most_departure;
        private System.Windows.Forms.Label most_month1;
        private System.Windows.Forms.TextBox most_month;
        private System.Windows.Forms.Label most_sex1;
        private System.Windows.Forms.TextBox most_sex;
        private System.Windows.Forms.Label most_end_station1;
        private System.Windows.Forms.TextBox most_end_station;
        private System.Windows.Forms.Label most_start_station1;
        private System.Windows.Forms.TextBox most_start_station;
        private System.Windows.Forms.Button showinfo;
        private System.Windows.Forms.ComboBox startstat;
        private System.Windows.Forms.ComboBox endstat;
        private System.Windows.Forms.ComboBox triptime;
        private System.Windows.Forms.ComboBox Gender;
    }
}