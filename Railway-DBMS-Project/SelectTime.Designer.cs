﻿namespace RailWay
{
    partial class SelectTime
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelTimeDGV = new System.Windows.Forms.DataGridView();
            this.SelTimeCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SelTimeDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Finish";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Departure Time";
            // 
            // SelTimeDGV
            // 
            this.SelTimeDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SelTimeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelTimeDGV.Location = new System.Drawing.Point(33, 24);
            this.SelTimeDGV.Name = "SelTimeDGV";
            this.SelTimeDGV.Size = new System.Drawing.Size(470, 202);
            this.SelTimeDGV.TabIndex = 13;
            // 
            // SelTimeCB
            // 
            this.SelTimeCB.FormattingEnabled = true;
            this.SelTimeCB.Location = new System.Drawing.Point(222, 250);
            this.SelTimeCB.Name = "SelTimeCB";
            this.SelTimeCB.Size = new System.Drawing.Size(114, 21);
            this.SelTimeCB.TabIndex = 14;
            this.SelTimeCB.SelectedIndexChanged += new System.EventHandler(this.SelTimeCB_SelectedIndexChanged);
            // 
            // SelectTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 345);
            this.Controls.Add(this.SelTimeCB);
            this.Controls.Add(this.SelTimeDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "SelectTime";
            this.Text = "SelectTime";
            this.Load += new System.EventHandler(this.SelectTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelTimeDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView SelTimeDGV;
        private System.Windows.Forms.ComboBox SelTimeCB;
    }
}