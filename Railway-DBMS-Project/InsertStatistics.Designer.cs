namespace RailWay
{
    partial class InsertStatistics
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
            this.popmonth = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tomonth = new System.Windows.Forms.NumericUpDown();
            this.frommonth = new System.Windows.Forms.NumericUpDown();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.triptime = new System.Windows.Forms.ComboBox();
            this.endstat = new System.Windows.Forms.ComboBox();
            this.startstat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.popmonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frommonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.SuspendLayout();
            // 
            // popmonth
            // 
            this.popmonth.Location = new System.Drawing.Point(236, 245);
            this.popmonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.popmonth.Name = "popmonth";
            this.popmonth.Size = new System.Drawing.Size(100, 20);
            this.popmonth.TabIndex = 50;
            this.popmonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(421, 124);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(103, 47);
            this.insert.TabIndex = 44;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Location = new System.Drawing.Point(27, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Popular End Station";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(27, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Popular Start Station";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Location = new System.Drawing.Point(27, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Popular Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(27, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Popular Sex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(27, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Popular Trip Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Location = new System.Drawing.Point(27, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "From Month";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label8.Location = new System.Drawing.Point(27, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Till Month";
            // 
            // tomonth
            // 
            this.tomonth.Increment = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.tomonth.Location = new System.Drawing.Point(236, 88);
            this.tomonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.tomonth.Name = "tomonth";
            this.tomonth.Size = new System.Drawing.Size(100, 20);
            this.tomonth.TabIndex = 56;
            this.tomonth.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // frommonth
            // 
            this.frommonth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.frommonth.Location = new System.Drawing.Point(236, 50);
            this.frommonth.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.frommonth.Name = "frommonth";
            this.frommonth.Size = new System.Drawing.Size(100, 20);
            this.frommonth.TabIndex = 54;
            this.frommonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(236, 12);
            this.year.Maximum = new decimal(new int[] {
            2060,
            0,
            0,
            0});
            this.year.MaximumSize = new System.Drawing.Size(1000000, 0);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 20);
            this.year.TabIndex = 5000000;
            this.year.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(236, 202);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(121, 21);
            this.Gender.TabIndex = 5000004;
            // 
            // triptime
            // 
            this.triptime.FormattingEnabled = true;
            this.triptime.Location = new System.Drawing.Point(236, 282);
            this.triptime.Name = "triptime";
            this.triptime.Size = new System.Drawing.Size(121, 21);
            this.triptime.TabIndex = 5000003;
            // 
            // endstat
            // 
            this.endstat.FormattingEnabled = true;
            this.endstat.Location = new System.Drawing.Point(236, 161);
            this.endstat.Name = "endstat";
            this.endstat.Size = new System.Drawing.Size(121, 21);
            this.endstat.TabIndex = 5000002;
            // 
            // startstat
            // 
            this.startstat.FormattingEnabled = true;
            this.startstat.Location = new System.Drawing.Point(236, 124);
            this.startstat.Name = "startstat";
            this.startstat.Size = new System.Drawing.Size(121, 21);
            this.startstat.TabIndex = 5000001;
            // 
            // InsertStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 400);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.triptime);
            this.Controls.Add(this.endstat);
            this.Controls.Add(this.startstat);
            this.Controls.Add(this.year);
            this.Controls.Add(this.tomonth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.frommonth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.popmonth);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "InsertStatistics";
            this.Text = "InsertStatistics";
            this.Load += new System.EventHandler(this.InsertStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popmonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frommonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown popmonth;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown tomonth;
        private System.Windows.Forms.NumericUpDown frommonth;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.ComboBox triptime;
        private System.Windows.Forms.ComboBox endstat;
        private System.Windows.Forms.ComboBox startstat;
    }
}