namespace RailWay
{
    partial class Statistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewButton = new System.Windows.Forms.Button();
            this.EditButton7 = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.FromComboBox = new System.Windows.Forms.ComboBox();
            this.ToComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.most_start_station = new System.Windows.Forms.TextBox();
            this.most_start_station1 = new System.Windows.Forms.Label();
            this.most_end_station1 = new System.Windows.Forms.Label();
            this.most_end_station = new System.Windows.Forms.TextBox();
            this.most_sex1 = new System.Windows.Forms.Label();
            this.most_sex = new System.Windows.Forms.TextBox();
            this.most_month1 = new System.Windows.Forms.Label();
            this.most_month = new System.Windows.Forms.TextBox();
            this.most_trip1 = new System.Windows.Forms.Label();
            this.most_departure = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(334, 26);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 5;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // EditButton7
            // 
            this.EditButton7.Location = new System.Drawing.Point(334, 55);
            this.EditButton7.Name = "EditButton7";
            this.EditButton7.Size = new System.Drawing.Size(75, 23);
            this.EditButton7.TabIndex = 7;
            this.EditButton7.Text = "Edit";
            this.EditButton7.UseVisualStyleBackColor = true;
            this.EditButton7.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(334, 84);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Year";
            // 
            // YearComboBox
            // 
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Location = new System.Drawing.Point(81, 30);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(71, 21);
            this.YearComboBox.TabIndex = 11;
            this.YearComboBox.SelectedIndexChanged += new System.EventHandler(this.YearComboBox_SelectedIndexChanged);
            // 
            // FromComboBox
            // 
            this.FromComboBox.FormattingEnabled = true;
            this.FromComboBox.Location = new System.Drawing.Point(81, 57);
            this.FromComboBox.Name = "FromComboBox";
            this.FromComboBox.Size = new System.Drawing.Size(71, 21);
            this.FromComboBox.TabIndex = 12;
            this.FromComboBox.SelectedIndexChanged += new System.EventHandler(this.FromComboBox_SelectedIndexChanged);
            // 
            // ToComboBox
            // 
            this.ToComboBox.FormattingEnabled = true;
            this.ToComboBox.Location = new System.Drawing.Point(81, 91);
            this.ToComboBox.Name = "ToComboBox";
            this.ToComboBox.Size = new System.Drawing.Size(71, 21);
            this.ToComboBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // most_start_station
            // 
            this.most_start_station.Enabled = false;
            this.most_start_station.Location = new System.Drawing.Point(17, 205);
            this.most_start_station.Name = "most_start_station";
            this.most_start_station.Size = new System.Drawing.Size(120, 20);
            this.most_start_station.TabIndex = 15;
            // 
            // most_start_station1
            // 
            this.most_start_station1.AutoSize = true;
            this.most_start_station1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.most_start_station1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.most_start_station1.Location = new System.Drawing.Point(32, 189);
            this.most_start_station1.Name = "most_start_station1";
            this.most_start_station1.Size = new System.Drawing.Size(91, 13);
            this.most_start_station1.TabIndex = 16;
            this.most_start_station1.Text = "Most Start Station";
            this.most_start_station1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.most_start_station1.Click += new System.EventHandler(this.most_start_station1_Click);
            // 
            // most_end_station1
            // 
            this.most_end_station1.AutoSize = true;
            this.most_end_station1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.most_end_station1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.most_end_station1.Location = new System.Drawing.Point(188, 189);
            this.most_end_station1.Name = "most_end_station1";
            this.most_end_station1.Size = new System.Drawing.Size(88, 13);
            this.most_end_station1.TabIndex = 18;
            this.most_end_station1.Text = "Most End Station";
            this.most_end_station1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // most_end_station
            // 
            this.most_end_station.Enabled = false;
            this.most_end_station.Location = new System.Drawing.Point(169, 205);
            this.most_end_station.Name = "most_end_station";
            this.most_end_station.Size = new System.Drawing.Size(120, 20);
            this.most_end_station.TabIndex = 17;
            this.most_end_station.TextChanged += new System.EventHandler(this.most_end_station_TextChanged);
            // 
            // most_sex1
            // 
            this.most_sex1.AutoSize = true;
            this.most_sex1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.most_sex1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.most_sex1.Location = new System.Drawing.Point(314, 189);
            this.most_sex1.Name = "most_sex1";
            this.most_sex1.Size = new System.Drawing.Size(68, 13);
            this.most_sex1.TabIndex = 20;
            this.most_sex1.Text = "Most Gender";
            this.most_sex1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // most_sex
            // 
            this.most_sex.Enabled = false;
            this.most_sex.Location = new System.Drawing.Point(317, 205);
            this.most_sex.Name = "most_sex";
            this.most_sex.Size = new System.Drawing.Size(64, 20);
            this.most_sex.TabIndex = 19;
            // 
            // most_month1
            // 
            this.most_month1.AutoSize = true;
            this.most_month1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.most_month1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.most_month1.Location = new System.Drawing.Point(404, 189);
            this.most_month1.Name = "most_month1";
            this.most_month1.Size = new System.Drawing.Size(63, 13);
            this.most_month1.TabIndex = 22;
            this.most_month1.Text = "Most Month";
            this.most_month1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // most_month
            // 
            this.most_month.Enabled = false;
            this.most_month.Location = new System.Drawing.Point(407, 205);
            this.most_month.Name = "most_month";
            this.most_month.Size = new System.Drawing.Size(60, 20);
            this.most_month.TabIndex = 21;
            // 
            // most_trip1
            // 
            this.most_trip1.AutoSize = true;
            this.most_trip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.most_trip1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.most_trip1.Location = new System.Drawing.Point(510, 189);
            this.most_trip1.Name = "most_trip1";
            this.most_trip1.Size = new System.Drawing.Size(77, 13);
            this.most_trip1.TabIndex = 24;
            this.most_trip1.Text = "Most Trip Time";
            this.most_trip1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // most_departure
            // 
            this.most_departure.Enabled = false;
            this.most_departure.Location = new System.Drawing.Point(489, 205);
            this.most_departure.Name = "most_departure";
            this.most_departure.Size = new System.Drawing.Size(120, 20);
            this.most_departure.TabIndex = 23;
            this.most_departure.TextChanged += new System.EventHandler(this.most_trip_TextChanged);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(457, 41);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(116, 51);
            this.insert.TabIndex = 25;
            this.insert.Text = "Insert New Statistic";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 314);
            this.Controls.Add(this.insert);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ToComboBox);
            this.Controls.Add(this.FromComboBox);
            this.Controls.Add(this.YearComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton7);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button EditButton7;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.ComboBox FromComboBox;
        private System.Windows.Forms.ComboBox ToComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox most_start_station;
        private System.Windows.Forms.Label most_start_station1;
        private System.Windows.Forms.Label most_end_station1;
        private System.Windows.Forms.TextBox most_end_station;
        private System.Windows.Forms.Label most_sex1;
        private System.Windows.Forms.TextBox most_sex;
        private System.Windows.Forms.Label most_month1;
        private System.Windows.Forms.TextBox most_month;
        private System.Windows.Forms.Label most_trip1;
        private System.Windows.Forms.TextBox most_departure;
        private System.Windows.Forms.Button insert;
    }
}