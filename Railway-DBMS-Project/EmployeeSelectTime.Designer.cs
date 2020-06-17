namespace RailWay
{
    partial class EmployeeSelectTime
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
            this.SelTimeCB = new System.Windows.Forms.ComboBox();
            this.SelTimeDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NumVal = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SelTimeDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumVal)).BeginInit();
            this.SuspendLayout();
            // 
            // SelTimeCB
            // 
            this.SelTimeCB.FormattingEnabled = true;
            this.SelTimeCB.Location = new System.Drawing.Point(172, 269);
            this.SelTimeCB.Name = "SelTimeCB";
            this.SelTimeCB.Size = new System.Drawing.Size(206, 21);
            this.SelTimeCB.TabIndex = 21;
            // 
            // SelTimeDGV
            // 
            this.SelTimeDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SelTimeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelTimeDGV.Location = new System.Drawing.Point(30, 32);
            this.SelTimeDGV.Name = "SelTimeDGV";
            this.SelTimeDGV.Size = new System.Drawing.Size(577, 202);
            this.SelTimeDGV.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Time";
            // 
            // NumVal
            // 
            this.NumVal.Location = new System.Drawing.Point(172, 322);
            this.NumVal.Name = "NumVal";
            this.NumVal.Size = new System.Drawing.Size(206, 20);
            this.NumVal.TabIndex = 18;
            this.NumVal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Quantity";
            // 
            // EmployeeSelectTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 414);
            this.Controls.Add(this.SelTimeCB);
            this.Controls.Add(this.SelTimeDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumVal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "EmployeeSelectTime";
            this.Text = "Select Time - Employee";
            ((System.ComponentModel.ISupportInitialize)(this.SelTimeDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelTimeCB;
        private System.Windows.Forms.DataGridView SelTimeDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumVal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}