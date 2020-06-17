namespace RailWay
{
    partial class Other_Passengers_Info
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
            this.back = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.agebox = new System.Windows.Forms.NumericUpDown();
            this.sexbox = new System.Windows.Forms.ComboBox();
            this.finish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FromStCB = new System.Windows.Forms.ComboBox();
            this.ToStCB = new System.Windows.Forms.ComboBox();
            this.TrackCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SelTimeCB = new System.Windows.Forms.ComboBox();
            this.SelTimeDGV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelTimeDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 387);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 18;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(454, 387);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 17;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(17, 24);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(88, 13);
            this.name.TabIndex = 20;
            this.name.Text = "Passenger Name";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(17, 65);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(79, 13);
            this.age.TabIndex = 21;
            this.age.Text = "Passenger Age";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(17, 107);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(78, 13);
            this.sex.TabIndex = 22;
            this.sex.Text = "Passenger Sex";
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(123, 21);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(175, 20);
            this.nametextbox.TabIndex = 23;
            this.nametextbox.TextChanged += new System.EventHandler(this.nametextbox_TextChanged);
            // 
            // agebox
            // 
            this.agebox.Location = new System.Drawing.Point(123, 63);
            this.agebox.Name = "agebox";
            this.agebox.Size = new System.Drawing.Size(84, 20);
            this.agebox.TabIndex = 24;
            this.agebox.ValueChanged += new System.EventHandler(this.agebox_ValueChanged);
            // 
            // sexbox
            // 
            this.sexbox.FormattingEnabled = true;
            this.sexbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexbox.Location = new System.Drawing.Point(123, 107);
            this.sexbox.Name = "sexbox";
            this.sexbox.Size = new System.Drawing.Size(84, 21);
            this.sexbox.TabIndex = 25;
            this.sexbox.SelectedIndexChanged += new System.EventHandler(this.sexbox_SelectedIndexChanged);
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(561, 387);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(75, 23);
            this.finish.TabIndex = 19;
            this.finish.Text = "Finish";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "To";
            // 
            // FromStCB
            // 
            this.FromStCB.FormattingEnabled = true;
            this.FromStCB.Location = new System.Drawing.Point(94, 224);
            this.FromStCB.Name = "FromStCB";
            this.FromStCB.Size = new System.Drawing.Size(180, 21);
            this.FromStCB.TabIndex = 28;
            this.FromStCB.SelectedIndexChanged += new System.EventHandler(this.FromStCB_SelectedIndexChanged);
            // 
            // ToStCB
            // 
            this.ToStCB.FormattingEnabled = true;
            this.ToStCB.Location = new System.Drawing.Point(94, 265);
            this.ToStCB.Name = "ToStCB";
            this.ToStCB.Size = new System.Drawing.Size(180, 21);
            this.ToStCB.TabIndex = 29;
            this.ToStCB.SelectedIndexChanged += new System.EventHandler(this.ToStCB_SelectedIndexChanged);
            // 
            // TrackCB
            // 
            this.TrackCB.FormattingEnabled = true;
            this.TrackCB.Location = new System.Drawing.Point(94, 181);
            this.TrackCB.Name = "TrackCB";
            this.TrackCB.Size = new System.Drawing.Size(180, 21);
            this.TrackCB.TabIndex = 30;
            this.TrackCB.SelectedIndexChanged += new System.EventHandler(this.TrackCB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "(VIP or Normal)";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(94, 347);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(180, 20);
            this.Date.TabIndex = 32;
            this.Date.Text = "yyyy-mm-dd";
            this.Date.TextChanged += new System.EventHandler(this.Date_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ticket Type";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Track";
            // 
            // SelTimeCB
            // 
            this.SelTimeCB.FormattingEnabled = true;
            this.SelTimeCB.Location = new System.Drawing.Point(497, 236);
            this.SelTimeCB.Name = "SelTimeCB";
            this.SelTimeCB.Size = new System.Drawing.Size(114, 21);
            this.SelTimeCB.TabIndex = 39;
            this.SelTimeCB.SelectedIndexChanged += new System.EventHandler(this.SelTimeCB_SelectedIndexChanged);
            // 
            // SelTimeDGV
            // 
            this.SelTimeDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SelTimeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelTimeDGV.Location = new System.Drawing.Point(354, 51);
            this.SelTimeDGV.Name = "SelTimeDGV";
            this.SelTimeDGV.Size = new System.Drawing.Size(303, 165);
            this.SelTimeDGV.TabIndex = 38;
            this.SelTimeDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelTimeDGV_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Departure Time";
            // 
            // Other_Passengers_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 416);
            this.Controls.Add(this.SelTimeCB);
            this.Controls.Add(this.SelTimeDGV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TrackCB);
            this.Controls.Add(this.ToStCB);
            this.Controls.Add(this.FromStCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sexbox);
            this.Controls.Add(this.agebox);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.back);
            this.Controls.Add(this.next);
            this.Name = "Other_Passengers_Info";
            this.Text = "Other_Passengers_Info";
            this.Load += new System.EventHandler(this.Other_Passengers_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelTimeDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.NumericUpDown agebox;
        private System.Windows.Forms.ComboBox sexbox;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FromStCB;
        private System.Windows.Forms.ComboBox ToStCB;
        private System.Windows.Forms.ComboBox TrackCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SelTimeCB;
        private System.Windows.Forms.DataGridView SelTimeDGV;
        private System.Windows.Forms.Label label7;
    }
}