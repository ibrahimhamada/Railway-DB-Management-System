namespace RailWay
{
    partial class Employee
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
            this.label4 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TrackCB = new System.Windows.Forms.ComboBox();
            this.ToStCB = new System.Windows.Forms.ComboBox();
            this.FromStCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Date";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(119, 248);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(180, 20);
            this.Date.TabIndex = 19;
            this.Date.Text = "yyyy-mm-dd";
            this.Date.TextChanged += new System.EventHandler(this.Date_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Track";
            // 
            // TrackCB
            // 
            this.TrackCB.FormattingEnabled = true;
            this.TrackCB.Location = new System.Drawing.Point(119, 106);
            this.TrackCB.Name = "TrackCB";
            this.TrackCB.Size = new System.Drawing.Size(180, 21);
            this.TrackCB.TabIndex = 17;
            this.TrackCB.SelectedIndexChanged += new System.EventHandler(this.TrackCB_SelectedIndexChanged);
            // 
            // ToStCB
            // 
            this.ToStCB.FormattingEnabled = true;
            this.ToStCB.Location = new System.Drawing.Point(119, 201);
            this.ToStCB.Name = "ToStCB";
            this.ToStCB.Size = new System.Drawing.Size(180, 21);
            this.ToStCB.TabIndex = 16;
            this.ToStCB.SelectedIndexChanged += new System.EventHandler(this.ToStCB_SelectedIndexChanged);
            // 
            // FromStCB
            // 
            this.FromStCB.FormattingEnabled = true;
            this.FromStCB.Location = new System.Drawing.Point(119, 150);
            this.FromStCB.Name = "FromStCB";
            this.FromStCB.Size = new System.Drawing.Size(180, 21);
            this.FromStCB.TabIndex = 15;
            this.FromStCB.SelectedIndexChanged += new System.EventHandler(this.FromStCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "From";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Send a Request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 363);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TrackCB);
            this.Controls.Add(this.ToStCB);
            this.Controls.Add(this.FromStCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Emplloyee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TrackCB;
        private System.Windows.Forms.ComboBox ToStCB;
        private System.Windows.Forms.ComboBox FromStCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}